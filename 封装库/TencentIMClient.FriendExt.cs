using TencentIM.Native.Interop;

namespace TencentIM.Native;

/// <summary>
/// 好友管理扩展
/// </summary>
public partial class TencentIMClient
{
    public async Task<bool> TIMFriendshipGetFriendsInfo(string jsonGetFriendsInfoParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMFriendshipGetFriendsInfo(jsonGetFriendsInfoParam, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMFriendshipModifyFriendProfile(string jsonModifyFriendInfoParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMFriendshipModifyFriendProfile(jsonModifyFriendInfoParam, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMFriendshipSearchFriends(string jsonSearchFriendsParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMFriendshipSearchFriends(jsonSearchFriendsParam, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMFriendshipCheckFriendType(string jsonCheckFriendListParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMFriendshipCheckFriendType(jsonCheckFriendListParam, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMFriendshipGetPendencyList(string jsonGetPendencyListParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMFriendshipGetPendencyList(jsonGetPendencyListParam, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMFriendshipHandleFriendAddRequest(string jsonHandleFriendAddParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMFriendshipHandleFriendAddRequest(jsonHandleFriendAddParam, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMFriendshipReportPendencyReaded(ulong timeStamp) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMFriendshipReportPendencyReaded(timeStamp, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMFriendshipDeletePendency(string jsonDeletePendencyParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMFriendshipDeletePendency(jsonDeletePendencyParam, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMFriendshipGetBlackList() => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMFriendshipGetBlackList(IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMFriendshipAddToBlackList(string jsonAddToBlacklistParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMFriendshipAddToBlackList(jsonAddToBlacklistParam, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMFriendshipDeleteFromBlackList(string jsonDeleteFromBlacklistParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMFriendshipDeleteFromBlackList(jsonDeleteFromBlacklistParam, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMFriendshipCreateFriendGroup(string jsonCreateFriendGroupParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMFriendshipCreateFriendGroup(jsonCreateFriendGroupParam, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMFriendshipGetFriendGroupList(string jsonGetFriendGroupListParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMFriendshipGetFriendGroupList(jsonGetFriendGroupListParam, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMFriendshipDeleteFriendGroup(string jsonDeleteFriendGroupParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMFriendshipDeleteFriendGroup(jsonDeleteFriendGroupParam, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMFriendshipModifyFriendGroup(string jsonModifyFriendGroupParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMFriendshipModifyFriendGroup(jsonModifyFriendGroupParam, IntPtr.Zero, IntPtr.Zero) == 0;
}
