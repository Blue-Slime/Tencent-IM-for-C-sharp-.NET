using TencentIM.Native.Interop;

namespace TencentIM.Native;

/// <summary>
/// 消息扩展与反应功能
/// </summary>
public partial class TencentIMClient
{
    public async Task<bool> TIMMsgSetMessageExtensions(string jsonMsgParam, string jsonExtensionArray) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMMsgSetMessageExtensions(jsonMsgParam, jsonExtensionArray, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMMsgGetMessageExtensions(string jsonMsgParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMMsgGetMessageExtensions(jsonMsgParam, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMMsgDeleteMessageExtensions(string jsonMsgParam, string jsonExtensionKeyArray) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMMsgDeleteMessageExtensions(jsonMsgParam, jsonExtensionKeyArray, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMMsgAddMessageReaction(string jsonMsgParam, string reactionId) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMMsgAddMessageReaction(jsonMsgParam, reactionId, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMMsgRemoveMessageReaction(string jsonMsgParam, string reactionId) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMMsgRemoveMessageReaction(jsonMsgParam, reactionId, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMMsgGetMessageReactions(string jsonMsgArray) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMMsgGetMessageReactions(jsonMsgArray, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMMsgGetAllUserListOfMessageReaction(string jsonMsgParam, string reactionId, uint nextSeq, uint count) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMMsgGetAllUserListOfMessageReaction(jsonMsgParam, reactionId, nextSeq, count, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMMsgTranslateText(string jsonSourceTextArray, string targetLanguage) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMMsgTranslateText(jsonSourceTextArray, targetLanguage, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMPinGroupMessage(string groupId, string jsonMsgParam, bool isPin) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMPinGroupMessage(groupId, jsonMsgParam, isPin, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMGetPinnedMessageList(string groupId) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMGetPinnedMessageList(groupId, IntPtr.Zero, IntPtr.Zero) == 0;
}
