using System.Text.Json;
using TencentIM.Native.Interop;
using TencentIM.Native.Models;

namespace TencentIM.Native;

/// <summary>
/// 消息操作扩展
/// </summary>
public partial class TencentIMClient
{
    /// <summary>
    /// 撤回消息 (对应 TIMMsgRevoke)
    /// </summary>
    public async Task<bool> TIMMsgRevoke(string convId, TIMConvType convType, string jsonMsgParam)
    {
        if (!_isLoggedIn)
            throw new InvalidOperationException("Not logged in");

        var ret = TIMNative.TIMMsgRevoke(convId, (int)convType, jsonMsgParam, IntPtr.Zero, IntPtr.Zero);
        return ret == 0;
    }

    /// <summary>
    /// 删除消息 (对应 TIMMsgDelete)
    /// </summary>
    public async Task<bool> TIMMsgDelete(string convId, TIMConvType convType, string jsonMsgDelParam)
    {
        if (!_isLoggedIn)
            throw new InvalidOperationException("Not logged in");

        var ret = TIMNative.TIMMsgDelete(convId, (int)convType, jsonMsgDelParam, IntPtr.Zero, IntPtr.Zero);
        return ret == 0;
    }

    /// <summary>
    /// 获取消息列表 (对应 TIMMsgGetMsgList)
    /// </summary>
    public async Task<bool> TIMMsgGetMsgList(string convId, TIMConvType convType, string jsonGetMsgParam)
    {
        if (!_isLoggedIn)
            throw new InvalidOperationException("Not logged in");

        var ret = TIMNative.TIMMsgGetMsgList(convId, (int)convType, jsonGetMsgParam, IntPtr.Zero, IntPtr.Zero);
        return ret == 0;
    }
}
