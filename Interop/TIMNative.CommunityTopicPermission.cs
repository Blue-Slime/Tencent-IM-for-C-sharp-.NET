using System.Runtime.InteropServices;

namespace TencentIM.Native.Interop;

/// <summary>
/// 社群话题权限管理接口
/// </summary>
public static partial class TIMNative
{
    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMCommunityAddTopicPermissionToPermissionGroup(
        [MarshalAs(UnmanagedType.LPStr)] string group_id,
        [MarshalAs(UnmanagedType.LPStr)] string permission_group_id,
        [MarshalAs(UnmanagedType.LPStr)] string json_topic_permission,
        TIMCommCallback callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMCommunityDeleteTopicPermissionFromPermissionGroup(
        [MarshalAs(UnmanagedType.LPStr)] string group_id,
        [MarshalAs(UnmanagedType.LPStr)] string permission_group_id,
        [MarshalAs(UnmanagedType.LPStr)] string json_topic_id_array,
        TIMCommCallback callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMCommunityModifyTopicPermissionInPermissionGroup(
        [MarshalAs(UnmanagedType.LPStr)] string group_id,
        [MarshalAs(UnmanagedType.LPStr)] string permission_group_id,
        [MarshalAs(UnmanagedType.LPStr)] string json_topic_permission,
        TIMCommCallback callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMCommunityGetTopicPermissionInPermissionGroup(
        [MarshalAs(UnmanagedType.LPStr)] string group_id,
        [MarshalAs(UnmanagedType.LPStr)] string permission_group_id,
        [MarshalAs(UnmanagedType.LPStr)] string json_topic_id_array,
        TIMCommCallback callback,
        IntPtr user_data);
}
