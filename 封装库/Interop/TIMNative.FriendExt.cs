using System.Runtime.InteropServices;

namespace TencentIM.Native.Interop;

/// <summary>
/// 好友管理扩展接口
/// </summary>
public static partial class TIMNative
{
    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMFriendshipGetFriendsInfo(
        [MarshalAs(UnmanagedType.LPStr)] string json_get_friends_info_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMFriendshipModifyFriendProfile(
        [MarshalAs(UnmanagedType.LPStr)] string json_modify_friend_info_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMFriendshipSearchFriends(
        [MarshalAs(UnmanagedType.LPStr)] string json_search_friends_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMFriendshipCheckFriendType(
        [MarshalAs(UnmanagedType.LPStr)] string json_check_friend_list_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMFriendshipGetPendencyList(
        [MarshalAs(UnmanagedType.LPStr)] string json_get_pendency_list_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMFriendshipHandleFriendAddRequest(
        [MarshalAs(UnmanagedType.LPStr)] string json_handle_friend_add_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int TIMFriendshipReportPendencyReaded(
        ulong time_stamp,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMFriendshipDeletePendency(
        [MarshalAs(UnmanagedType.LPStr)] string json_delete_pendency_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int TIMFriendshipGetBlackList(
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMFriendshipAddToBlackList(
        [MarshalAs(UnmanagedType.LPStr)] string json_add_to_blacklist_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMFriendshipDeleteFromBlackList(
        [MarshalAs(UnmanagedType.LPStr)] string json_delete_from_blacklist_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMFriendshipCreateFriendGroup(
        [MarshalAs(UnmanagedType.LPStr)] string json_create_friend_group_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMFriendshipGetFriendGroupList(
        [MarshalAs(UnmanagedType.LPStr)] string json_get_friend_group_list_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMFriendshipDeleteFriendGroup(
        [MarshalAs(UnmanagedType.LPStr)] string json_delete_friend_group_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMFriendshipModifyFriendGroup(
        [MarshalAs(UnmanagedType.LPStr)] string json_modify_friend_group_param,
        IntPtr callback,
        IntPtr user_data);
}
