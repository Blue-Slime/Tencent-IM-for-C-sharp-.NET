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
    private TaskCompletionSource<bool>? _loginTcs;
    private TIMCommCallback? _loginCallback;

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

        _loginTcs = new TaskCompletionSource<bool>();
        _loginCallback = (code, desc, json, userData) =>
        {
            if (code == 0)
            {
                _isLoggedIn = true;
                OnConnected?.Invoke(this, EventArgs.Empty);
                _loginTcs?.TrySetResult(true);
            }
            else
            {
                Console.WriteLine($"Login failed: code={code}, desc={desc}");
                _loginTcs?.TrySetResult(false);
            }
        };

        var ret = TIMNative.TIMLogin(userId, userSig, _loginCallback, IntPtr.Zero);
        if (ret != 0)
        {
            _loginTcs.TrySetResult(false);
            return false;
        }

        return await _loginTcs.Task;
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
            Console.WriteLine($"[DEBUG] 收到消息JSON: {jsonMsgArray}");

            // 先触发原始消息事件，让UI显示
            OnMessageReceived?.Invoke(this, new MessageReceivedEventArgs
            {
                SenderId = "RAW_JSON",
                Content = jsonMsgArray
            });
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Parse message error: {ex.Message}");
        }
    }

    private void AddLog(string message)
    {
        Console.WriteLine($"[TencentIMClient] {message}");
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
