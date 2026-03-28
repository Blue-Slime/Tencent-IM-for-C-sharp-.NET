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

    /// <summary>
    /// 下载消息元素到指定路径 (对应 TIMMsgDownloadElemToPath)
    /// </summary>
    public async Task<bool> TIMMsgDownloadElemToPath(string jsonDownloadElemParam, string path)
    {
        if (!_isLoggedIn)
            throw new InvalidOperationException("Not logged in");

        var ret = TIMNative.TIMMsgDownloadElemToPath(jsonDownloadElemParam, path, IntPtr.Zero, IntPtr.Zero);
        return ret == 0;
    }

    /// <summary>
    /// 设置C2C消息接收选项 (对应 TIMMsgSetC2CReceiveMessageOpt)
    /// </summary>
    public async Task<bool> TIMMsgSetC2CReceiveMessageOpt(string jsonIdentifierArray, int opt)
    {
        if (!_isLoggedIn)
            throw new InvalidOperationException("Not logged in");

        var ret = TIMNative.TIMMsgSetC2CReceiveMessageOpt(jsonIdentifierArray, opt, IntPtr.Zero, IntPtr.Zero);
        return ret == 0;
    }

    /// <summary>
    /// 获取C2C消息接收选项 (对应 TIMMsgGetC2CReceiveMessageOpt)
    /// </summary>
    public async Task<bool> TIMMsgGetC2CReceiveMessageOpt(string jsonIdentifierArray)
    {
        if (!_isLoggedIn)
            throw new InvalidOperationException("Not logged in");

        var ret = TIMNative.TIMMsgGetC2CReceiveMessageOpt(jsonIdentifierArray, IntPtr.Zero, IntPtr.Zero);
        return ret == 0;
    }

    /// <summary>
    /// 取消发送中的消息 (对应 TIMMsgCancelSend)
    /// </summary>
    public async Task<bool> TIMMsgCancelSend(string convId, TIMConvType convType, string jsonMsgParam)
    {
        if (!_isLoggedIn)
            throw new InvalidOperationException("Not logged in");

        var ret = TIMNative.TIMMsgCancelSend(convId, (int)convType, jsonMsgParam, IntPtr.Zero, IntPtr.Zero);
        return ret == 0;
    }

    /// <summary>
    /// 群发消息 (对应 TIMMsgBatchSend)
    /// </summary>
    public async Task<bool> TIMMsgBatchSend(string jsonBatchSendParam)
    {
        if (!_isLoggedIn)
            throw new InvalidOperationException("Not logged in");

        var ret = TIMNative.TIMMsgBatchSend(jsonBatchSendParam, IntPtr.Zero, IntPtr.Zero);
        return ret == 0;
    }

    /// <summary>
    /// 消息修改 (对应 TIMMsgModifyMessage)
    /// </summary>
    public async Task<bool> TIMMsgModifyMessage(string jsonMsgParam)
    {
        if (!_isLoggedIn)
            throw new InvalidOperationException("Not logged in");

        var ret = TIMNative.TIMMsgModifyMessage(jsonMsgParam, IntPtr.Zero, IntPtr.Zero);
        return ret == 0;
    }

    /// <summary>
    /// 删除消息列表 (对应 TIMMsgListDelete)
    /// </summary>
    public async Task<bool> TIMMsgListDelete(string convId, TIMConvType convType, string jsonMsgArray)
    {
        if (!_isLoggedIn)
            throw new InvalidOperationException("Not logged in");

        var ret = TIMNative.TIMMsgListDelete(convId, (int)convType, jsonMsgArray, IntPtr.Zero, IntPtr.Zero);
        return ret == 0;
    }

    /// <summary>
    /// 清空会话消息 (对应 TIMMsgClearHistoryMessage)
    /// </summary>
    public async Task<bool> TIMMsgClearHistoryMessage(string convId, TIMConvType convType)
    {
        if (!_isLoggedIn)
            throw new InvalidOperationException("Not logged in");

        var ret = TIMNative.TIMMsgClearHistoryMessage(convId, (int)convType, IntPtr.Zero, IntPtr.Zero);
        return ret == 0;
    }

    public async Task<bool> TIMMsgSaveMsg(string convId, TIMConvType convType, string jsonMsgParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMMsgSaveMsg(convId, (int)convType, jsonMsgParam, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMMsgImportMsgList(string convId, TIMConvType convType, string jsonMsgArray) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMMsgImportMsgList(convId, (int)convType, jsonMsgArray, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMMsgFindMessages(string jsonMessageIdArray) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMMsgFindMessages(jsonMessageIdArray, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMMsgFindByMsgLocatorList(string convId, TIMConvType convType, string jsonMsgLocatorArray) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMMsgFindByMsgLocatorList(convId, (int)convType, jsonMsgLocatorArray, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMMsgDownloadMergerMessage(string jsonMsgParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMMsgDownloadMergerMessage(jsonMsgParam, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMMsgSetLocalCustomData(string jsonMsgParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMMsgSetLocalCustomData(jsonMsgParam, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMMsgSearchLocalMessages(string jsonSearchMessageParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMMsgSearchLocalMessages(jsonSearchMessageParam, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMMsgSearchCloudMessages(string jsonSearchMessageParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMMsgSearchCloudMessages(jsonSearchMessageParam, IntPtr.Zero, IntPtr.Zero) == 0;
}
