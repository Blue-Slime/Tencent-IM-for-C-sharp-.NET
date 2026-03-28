using TencentIM.Native.Interop;

namespace TencentIM.Native;

/// <summary>
/// 群组高级功能扩展
/// </summary>
public partial class TencentIMClient
{
    public async Task<bool> TIMGroupSearchGroups(string jsonSearchGroupsParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMGroupSearchGroups(jsonSearchGroupsParam, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMGroupSearchCloudGroups(string jsonSearchGroupsParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMGroupSearchCloudGroups(jsonSearchGroupsParam, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMGroupGetJoinedCommunityList() => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMGroupGetJoinedCommunityList(IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMGroupSearchGroupMembers(string jsonSearchGroupMembersParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMGroupSearchGroupMembers(jsonSearchGroupMembersParam, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMGroupSearchCloudGroupMembers(string jsonSearchGroupMembersParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMGroupSearchCloudGroupMembers(jsonSearchGroupMembersParam, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMGroupMarkGroupMemberList(string groupId, string jsonIdentifierArray, uint markType, bool enableMark) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMGroupMarkGroupMemberList(groupId, jsonIdentifierArray, markType, enableMark, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMGroupGetPendencyList(string jsonGroupGetPendencyListParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMGroupGetPendencyList(jsonGroupGetPendencyListParam, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMGroupHandlePendency(string jsonGroupHandlePendencyParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMGroupHandlePendency(jsonGroupHandlePendencyParam, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMGroupReportPendencyReaded(ulong timeStamp) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMGroupReportPendencyReaded(timeStamp, IntPtr.Zero, IntPtr.Zero) == 0;
}
