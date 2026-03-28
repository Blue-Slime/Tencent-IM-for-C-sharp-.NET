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
    /// 初始化SDK
    /// </summary>
    public bool Initialize()
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
                // 设置消息回调
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
    /// 登录
    /// </summary>
    public async Task<bool> LoginAsync(string userId, string userSig)
    {
        if (!_isInitialized)
            throw new InvalidOperationException("SDK not initialized");

        var tcs = new TaskCompletionSource<bool>();

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
    /// 登出
    /// </summary>
    public async Task LogoutAsync()
    {
        if (!_isLoggedIn) return;

        TIMNative.TIMLogout(IntPtr.Zero, IntPtr.Zero);
        _isLoggedIn = false;
        OnDisconnected?.Invoke(this, EventArgs.Empty);
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
