using System.Runtime.InteropServices;
using System.Text.Json;
using TencentIM.Native.Interop;
using TencentIM.Native.Models;

namespace TencentIM.Native;

/// <summary>
/// 腾讯云IM客户端（封装C SDK）
/// </summary>
public partial class TencentIMClient : IDisposable
{
    private readonly long _sdkAppId;
    private bool _isInitialized;
    private bool _isLoggedIn;
    private TIMRecvNewMsgCallback? _msgCallback;

    public event EventHandler<MessageReceivedEventArgs>? OnMessageReceived;
    public event EventHandler? OnConnected;
    public event EventHandler? OnDisconnected;

    public TencentIMClient(long sdkAppId)
    {
        _sdkAppId = sdkAppId;
    }

    /// <summary>
    /// 初始化SDK (对应 TIMInit)
    /// </summary>
    public bool TIMInit()
    {
        if (_isInitialized) return true;

        var config = JsonSerializer.Serialize(new { });
        var configPtr = Marshal.StringToHGlobalAnsi(config);

        try
        {
            var ret = TIMNative.TIMInit(_sdkAppId, configPtr);
            Console.WriteLine($"[DEBUG] TIMInit返回值: {ret}");
            _isInitialized = ret == 0;

            if (_isInitialized)
            {
                _msgCallback = OnRecvNewMsg;
                TIMNative.TIMAddRecvNewMsgCallback(_msgCallback, IntPtr.Zero);
            }

            return _isInitialized;
        }
        finally
        {
            Marshal.FreeHGlobal(configPtr);
        }
    }

    /// <summary>
    /// 登录 (对应 TIMLogin)
    /// </summary>
    public async Task<bool> TIMLogin(string userId, string userSig)
    {
        if (!_isInitialized)
            throw new InvalidOperationException("SDK not initialized");

        var ret = TIMNative.TIMLogin(userId, userSig, IntPtr.Zero, IntPtr.Zero);

        if (ret == 0)
        {
            _isLoggedIn = true;
            OnConnected?.Invoke(this, EventArgs.Empty);
            return true;
        }

        return false;
    }

    /// <summary>
    /// 登出 (对应 TIMLogout)
    /// </summary>
    public async Task TIMLogout()
    {
        if (!_isLoggedIn) return;

        TIMNative.TIMLogout(IntPtr.Zero, IntPtr.Zero);
        _isLoggedIn = false;
        OnDisconnected?.Invoke(this, EventArgs.Empty);
    }

    /// <summary>
    /// 获取SDK版本 (对应 TIMGetSDKVersion)
    /// </summary>
    public string TIMGetSDKVersion()
    {
        var versionPtr = TIMNative.TIMGetSDKVersion();
        return Marshal.PtrToStringAnsi(versionPtr) ?? "";
    }

    /// <summary>
    /// 获取服务器时间 (对应 TIMGetServerTime)
    /// </summary>
    public ulong TIMGetServerTime()
    {
        return TIMNative.TIMGetServerTime();
    }

    /// <summary>
    /// 获取登录状态 (对应 TIMGetLoginStatus)
    /// </summary>
    public TIMLoginStatus TIMGetLoginStatus()
    {
        return TIMNative.TIMGetLoginStatus();
    }

    /// <summary>
    /// 获取当前登录用户ID (对应 TIMGetLoginUserID)
    /// </summary>
    public string TIMGetLoginUserID()
    {
        var buffer = new byte[128];
        var handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
        try
        {
            TIMNative.TIMGetLoginUserID(handle.AddrOfPinnedObject());
            return System.Text.Encoding.UTF8.GetString(buffer).TrimEnd('\0');
        }
        finally
        {
            handle.Free();
        }
    }

    /// <summary>
    /// 接收消息回调
    /// </summary>
    private void OnRecvNewMsg(string jsonMsgArray, IntPtr userData)
    {
        try
        {
            // 解析JSON消息
            var messages = JsonSerializer.Deserialize<List<Dictionary<string, object>>>(jsonMsgArray);
            if (messages == null) return;

            foreach (var msg in messages)
            {
                OnMessageReceived?.Invoke(this, new MessageReceivedEventArgs
                {
                    SenderId = msg.GetValueOrDefault("sender_id")?.ToString() ?? "",
                    Content = msg.GetValueOrDefault("content")?.ToString() ?? ""
                });
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Parse message error: {ex.Message}");
        }
    }

    public void Dispose()
    {
        if (_msgCallback != null)
        {
            TIMNative.TIMRemoveRecvNewMsgCallback(_msgCallback);
        }

        if (_isInitialized)
        {
            TIMNative.TIMUninit();
        }
    }
}

public class MessageReceivedEventArgs : EventArgs
{
    public string SenderId { get; set; } = "";
    public string Content { get; set; } = "";
}
