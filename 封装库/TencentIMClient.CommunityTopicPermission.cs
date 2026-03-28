using TencentIM.Native.Interop;

namespace TencentIM.Native;

/// <summary>
/// 社群话题权限管理接口
/// </summary>
public partial class TencentIMClient
{
    public async Task<bool> TIMCommunityAddTopicPermissionToPermissionGroup(string groupId, string permissionGroupId, string jsonTopicPermission)
        => await Task.Run(() => TIMNative.TIMCommunityAddTopicPermissionToPermissionGroup(groupId, permissionGroupId, jsonTopicPermission, (TIMCommCallback?)null, IntPtr.Zero) == 0);

    public async Task<bool> TIMCommunityDeleteTopicPermissionFromPermissionGroup(string groupId, string permissionGroupId, string jsonTopicIdArray)
        => await Task.Run(() => TIMNative.TIMCommunityDeleteTopicPermissionFromPermissionGroup(groupId, permissionGroupId, jsonTopicIdArray, (TIMCommCallback?)null, IntPtr.Zero) == 0);

    public async Task<bool> TIMCommunityModifyTopicPermissionInPermissionGroup(string groupId, string permissionGroupId, string jsonTopicPermission)
        => await Task.Run(() => TIMNative.TIMCommunityModifyTopicPermissionInPermissionGroup(groupId, permissionGroupId, jsonTopicPermission, (TIMCommCallback?)null, IntPtr.Zero) == 0);

    public async Task<bool> TIMCommunityGetTopicPermissionInPermissionGroup(string groupId, string permissionGroupId, string jsonTopicIdArray)
        => await Task.Run(() => TIMNative.TIMCommunityGetTopicPermissionInPermissionGroup(groupId, permissionGroupId, jsonTopicIdArray, (TIMCommCallback?)null, IntPtr.Zero) == 0);
}
