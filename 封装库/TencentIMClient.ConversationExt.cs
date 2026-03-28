using TencentIM.Native.Interop;
using TencentIM.Native.Models;

namespace TencentIM.Native;

/// <summary>
/// 会话扩展功能
/// </summary>
public partial class TencentIMClient
{
    public async Task<bool> TIMConvGetConvInfo(string jsonGetConvListParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMConvGetConvInfo(jsonGetConvListParam, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMConvGetConversationListByFilter(string jsonGetConversationListByFilterParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMConvGetConversationListByFilter(jsonGetConversationListByFilterParam, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMConvDeleteConversationList(string jsonConvIdArray, bool clearMessage) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMConvDeleteConversationList(jsonConvIdArray, clearMessage, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMConvSetDraft(string convId, TIMConvType convType, string jsonDraftParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMConvSetDraft(convId, (int)convType, jsonDraftParam) == 0;
    public async Task<bool> TIMConvCancelDraft(string convId, TIMConvType convType) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMConvCancelDraft(convId, (int)convType) == 0;
    public async Task<bool> TIMConvSetConversationCustomData(string jsonConversationArray) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMConvSetConversationCustomData(jsonConversationArray, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMConvPinConversation(string convId, TIMConvType convType, bool isPinned) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMConvPinConversation(convId, (int)convType, isPinned, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMConvMarkConversation(string jsonConversationIdArray, ulong markType, bool enableMark) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMConvMarkConversation(jsonConversationIdArray, markType, enableMark, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMConvGetTotalUnreadMessageCount() => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMConvGetTotalUnreadMessageCount(IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMConvGetUnreadMessageCountByFilter(string jsonFilter) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMConvGetUnreadMessageCountByFilter(jsonFilter, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMConvSubscribeUnreadMessageCountByFilter(string jsonFilter) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMConvSubscribeUnreadMessageCountByFilter(jsonFilter) == 0;
    public async Task<bool> TIMConvUnsubscribeUnreadMessageCountByFilter(string jsonFilter) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMConvUnsubscribeUnreadMessageCountByFilter(jsonFilter) == 0;
    public async Task<bool> TIMConvCleanConversationUnreadMessageCount(string convId, TIMConvType convType, ulong cleanTimestamp, ulong cleanSequence) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMConvCleanConversationUnreadMessageCount(convId, (int)convType, cleanTimestamp, cleanSequence, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMConvCreateConversationGroup(string groupName, string jsonConversationIdArray) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMConvCreateConversationGroup(groupName, jsonConversationIdArray, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMConvGetConversationGroupList() => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMConvGetConversationGroupList(IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMConvDeleteConversationGroup(string groupName) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMConvDeleteConversationGroup(groupName, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMConvRenameConversationGroup(string oldName, string newName) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMConvRenameConversationGroup(oldName, newName, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMConvAddConversationsToGroup(string groupName, string jsonConversationIdArray) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMConvAddConversationsToGroup(groupName, jsonConversationIdArray, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMConvDeleteConversationsFromGroup(string groupName, string jsonConversationIdArray) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMConvDeleteConversationsFromGroup(groupName, jsonConversationIdArray, IntPtr.Zero, IntPtr.Zero) == 0;
}
