using System.Runtime.InteropServices;

namespace TencentIM.Native.Interop;

/// <summary>
/// 用户资料相关接口
/// </summary>
public static partial class TIMNative
{
    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMProfileGetUserProfileList(
        [MarshalAs(UnmanagedType.LPStr)] string json_get_user_profile_list_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMProfileModifySelfUserProfile(
        [MarshalAs(UnmanagedType.LPStr)] string json_modify_self_user_profile_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMSubscribeUserInfo(
        [MarshalAs(UnmanagedType.LPStr)] string json_identifier_array,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMUnsubscribeUserInfo(
        [MarshalAs(UnmanagedType.LPStr)] string json_identifier_array,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMSearchUsers(
        [MarshalAs(UnmanagedType.LPStr)] string json_search_users_param,
        IntPtr callback,
        IntPtr user_data);
}
