using System.Runtime.InteropServices;

namespace TencentIM.Native.Interop;

/// <summary>
/// 群组相关的P/Invoke声明
/// </summary>
public static partial class TIMNative
{
    // ========== 群组管理 ==========

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGroupCreate(
        [MarshalAs(UnmanagedType.LPStr)] string json_group_create_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGroupJoin(
        [MarshalAs(UnmanagedType.LPStr)] string group_id,
        [MarshalAs(UnmanagedType.LPStr)] string hello_msg,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGroupQuit(
        [MarshalAs(UnmanagedType.LPStr)] string group_id,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGroupDelete(
        [MarshalAs(UnmanagedType.LPStr)] string group_id,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGroupInviteMember(
        [MarshalAs(UnmanagedType.LPStr)] string json_group_invite_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGroupDeleteMember(
        [MarshalAs(UnmanagedType.LPStr)] string json_group_delete_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGroupGetJoinedGroupList(
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGroupGetMemberInfoList(
        [MarshalAs(UnmanagedType.LPStr)] string group_id,
        [MarshalAs(UnmanagedType.LPStr)] string json_get_member_info_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGroupGetGroupInfoList(
        [MarshalAs(UnmanagedType.LPStr)] string json_group_getinfo_param,
        IntPtr callback,
        IntPtr user_data);
}
