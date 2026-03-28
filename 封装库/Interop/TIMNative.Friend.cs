using System.Runtime.InteropServices;

namespace TencentIM.Native.Interop;

/// <summary>
/// 好友管理相关接口
/// </summary>
public static partial class TIMNative
{
    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMFriendshipAddFriend(
        [MarshalAs(UnmanagedType.LPStr)] string json_add_friend_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMFriendshipDeleteFriend(
        [MarshalAs(UnmanagedType.LPStr)] string json_delete_friend_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMFriendshipGetFriendProfileList(
        IntPtr callback,
        IntPtr user_data);
}
