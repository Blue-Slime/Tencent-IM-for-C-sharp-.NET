using System.Runtime.InteropServices;

namespace TencentIM.Native.Interop;

/// <summary>
/// 社群权限组成员管理接口
/// </summary>
public static partial class TIMNative
{
    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMCommunityAddCommunityMembersToPermissionGroup(
        [MarshalAs(UnmanagedType.LPStr)] string group_id,
        [MarshalAs(UnmanagedType.LPStr)] string permission_group_id,
        [MarshalAs(UnmanagedType.LPStr)] string json_member_id_array,
        TIMCommCallback callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMCommunityRemoveCommunityMembersFromPermissionGroup(
        [MarshalAs(UnmanagedType.LPStr)] string group_id,
        [MarshalAs(UnmanagedType.LPStr)] string permission_group_id,
        [MarshalAs(UnmanagedType.LPStr)] string json_member_id_array,
        TIMCommCallback callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMCommunityGetCommunityMemberListInPermissionGroup(
        [MarshalAs(UnmanagedType.LPStr)] string group_id,
        [MarshalAs(UnmanagedType.LPStr)] string permission_group_id,
        ulong next_cursor,
        TIMCommCallback callback,
        IntPtr user_data);
}
