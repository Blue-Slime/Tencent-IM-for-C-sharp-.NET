namespace TencentIM.Native;

/// <summary>
/// 社群权限组成员管理接口
/// </summary>
public partial class TencentIMClient
{
    public async Task<bool> TIMCommunityAddCommunityMembersToPermissionGroup(string groupId, string permissionGroupId, string jsonMemberIdArray)
        => await Task.Run(() => TIMNative.TIMCommunityAddCommunityMembersToPermissionGroup(groupId, permissionGroupId, jsonMemberIdArray, IntPtr.Zero, IntPtr.Zero) == 0);

    public async Task<bool> TIMCommunityRemoveCommunityMembersFromPermissionGroup(string groupId, string permissionGroupId, string jsonMemberIdArray)
        => await Task.Run(() => TIMNative.TIMCommunityRemoveCommunityMembersFromPermissionGroup(groupId, permissionGroupId, jsonMemberIdArray, IntPtr.Zero, IntPtr.Zero) == 0);

    public async Task<bool> TIMCommunityGetCommunityMemberListInPermissionGroup(string groupId, string permissionGroupId, ulong nextCursor)
        => await Task.Run(() => TIMNative.TIMCommunityGetCommunityMemberListInPermissionGroup(groupId, permissionGroupId, nextCursor, IntPtr.Zero, IntPtr.Zero) == 0);
}
