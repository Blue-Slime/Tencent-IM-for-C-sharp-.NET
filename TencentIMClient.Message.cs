using System.Text.Json;
using TencentIM.Native.Interop;
using TencentIM.Native.Models;

namespace TencentIM.Native;

/// <summary>
/// 消息发送扩展 (对应 TIMMsgSendMessage)
/// </summary>
public partial class TencentIMClient
{
    /// <summary>
    /// 发送消息 (对应 TIMMsgSendMessage)
    /// </summary>
    public async Task<bool> TIMMsgSendMessage(string convId, TIMConvType convType, string jsonMsgParam)
    {
        if (!_isLoggedIn)
            throw new InvalidOperationException("Not logged in");

        var ret = TIMNative.TIMMsgSendMessage(convId, (int)convType, jsonMsgParam, IntPtr.Zero, IntPtr.Zero);
        return ret == 0;
    }
}
