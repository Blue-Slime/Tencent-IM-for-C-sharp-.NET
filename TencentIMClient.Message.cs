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
        return await SendTextMessageAsync(groupId, TIMConvType.Group, text);
    }

    /// <summary>
    /// 发送私聊文本消息
    /// </summary>
    public async Task<bool> SendC2CTextMessageAsync(string userId, string text)
    {
        return await SendTextMessageAsync(userId, TIMConvType.C2C, text);
    }

    /// <summary>
    /// 发送文本消息（通用）
    /// </summary>
    private async Task<bool> SendTextMessageAsync(string convId, TIMConvType convType, string text)
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
        var ret = TIMNative.TIMMsgSendMessage(convId, (int)convType, json, IntPtr.Zero, IntPtr.Zero);
        return ret == 0;
    }

    /// <summary>
    /// 发送图片消息
    /// </summary>
    public async Task<bool> SendImageMessageAsync(string convId, TIMConvType convType, string imagePath)
    {
        if (!_isLoggedIn)
            throw new InvalidOperationException("Not logged in");

        var msgParam = new
        {
            message_elem_array = new[]
            {
                new
                {
                    elem_type = (int)TIMElemType.Image,
                    image_elem_orig_path = imagePath,
                    image_elem_level = 0
                }
            }
        };

        var json = JsonSerializer.Serialize(msgParam);
        var ret = TIMNative.TIMMsgSendMessage(convId, (int)convType, json, IntPtr.Zero, IntPtr.Zero);
        return ret == 0;
    }

    /// <summary>
    /// 发送文件消息
    /// </summary>
    public async Task<bool> SendFileMessageAsync(string convId, TIMConvType convType, string filePath)
    {
        if (!_isLoggedIn)
            throw new InvalidOperationException("Not logged in");

        var msgParam = new
        {
            message_elem_array = new[]
            {
                new
                {
                    elem_type = (int)TIMElemType.File,
                    file_elem_file_path = filePath
                }
            }
        };

        var json = JsonSerializer.Serialize(msgParam);
        var ret = TIMNative.TIMMsgSendMessage(convId, (int)convType, json, IntPtr.Zero, IntPtr.Zero);
        return ret == 0;
    }
}
