using System.Runtime.InteropServices;

namespace TencentIM.Native.Interop;

/// <summary>
/// 社群权限组相关接口
/// </summary>
public static partial class TIMNative
{
    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMCommunityCreatePermissionGroupInCommunity(
        [MarshalAs(UnmanagedType.LPStr)] string group_id,
        [MarshalAs(UnmanagedType.LPStr)] string json_permission_group_info,
        TIMCommCallback callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMCommunityDeletePermissionGroupFromCommunity(
        [MarshalAs(UnmanagedType.LPStr)] string group_id,
        [MarshalAs(UnmanagedType.LPStr)] string json_permission_group_id_array,
        TIMCommCallback callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMCommunityModifyPermissionGroupInfoInCommunity(
        [MarshalAs(UnmanagedType.LPStr)] string group_id,
        [MarshalAs(UnmanagedType.LPStr)] string json_permission_group_info,
        TIMCommCallback callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMCommunityGetJoinedPermissionGroupListInCommunity(
        [MarshalAs(UnmanagedType.LPStr)] string group_id,
        TIMCommCallback callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMCommunityGetPermissionGroupListInCommunity(
        [MarshalAs(UnmanagedType.LPStr)] string group_id,
        [MarshalAs(UnmanagedType.LPStr)] string json_permission_group_id_array,
        TIMCommCallback callback,
        IntPtr user_data);
}
