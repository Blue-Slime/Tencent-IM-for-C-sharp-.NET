using TencentIM.Native.Interop;

namespace TencentIM.Native;

/// <summary>
/// 社群权限组相关接口
/// </summary>
public partial class TencentIMClient
{
    public async Task<bool> TIMCommunityCreatePermissionGroupInCommunity(string groupId, string jsonPermissionGroupInfo)
        => await Task.Run(() => TIMNative.TIMCommunityCreatePermissionGroupInCommunity(groupId, jsonPermissionGroupInfo, (TIMCommCallback?)null, IntPtr.Zero) == 0);

    public async Task<bool> TIMCommunityDeletePermissionGroupFromCommunity(string groupId, string jsonPermissionGroupIdArray)
        => await Task.Run(() => TIMNative.TIMCommunityDeletePermissionGroupFromCommunity(groupId, jsonPermissionGroupIdArray, (TIMCommCallback?)null, IntPtr.Zero) == 0);

    public async Task<bool> TIMCommunityModifyPermissionGroupInfoInCommunity(string groupId, string jsonPermissionGroupInfo)
        => await Task.Run(() => TIMNative.TIMCommunityModifyPermissionGroupInfoInCommunity(groupId, jsonPermissionGroupInfo, (TIMCommCallback?)null, IntPtr.Zero) == 0);

    public async Task<bool> TIMCommunityGetJoinedPermissionGroupListInCommunity(string groupId)
        => await Task.Run(() => TIMNative.TIMCommunityGetJoinedPermissionGroupListInCommunity(groupId, (TIMCommCallback?)null, IntPtr.Zero) == 0);

    public async Task<bool> TIMCommunityGetPermissionGroupListInCommunity(string groupId, string jsonPermissionGroupIdArray)
        => await Task.Run(() => TIMNative.TIMCommunityGetPermissionGroupListInCommunity(groupId, jsonPermissionGroupIdArray, (TIMCommCallback?)null, IntPtr.Zero) == 0);
}
