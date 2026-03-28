using System.Text.Json;
using TencentIM.Native.Interop;
using TencentIM.Native.Models;

namespace TencentIM.Native;

/// <summary>
/// 消息发送扩展
/// </summary>
public partial class TencentIMClient
{
    /// <summary>
    /// 发送群组文本消息
    /// </summary>
    public async Task<bool> SendGroupTextMessageAsync(string groupId, string text)
    {
        if (!_isLoggedIn)
            throw new InvalidOperationException("Not logged in");

        var msgParam = new
        {
            message_elem_array = new[]
            {
                new
                {
                    elem_type = (int)TIMElemType.Text,
                    text_elem_content = text
                }
            }
        };

        var json = JsonSerializer.Serialize(msgParam);
        var ret = TIMNative.TIMMsgSendMessage(
            groupId,
            (int)TIMConvType.Group,
            json,
            IntPtr.Zero,
            IntPtr.Zero);

        return ret == 0;
    }
}
