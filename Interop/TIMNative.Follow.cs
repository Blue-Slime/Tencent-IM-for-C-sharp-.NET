using System.Runtime.InteropServices;

namespace TencentIM.Native.Interop;

/// <summary>
/// 关注与粉丝相关接口
/// </summary>
public static partial class TIMNative
{
    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMFollowUser(
        [MarshalAs(UnmanagedType.LPStr)] string json_user_id_array,
        TIMCommCallback callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMUnfollowUser(
        [MarshalAs(UnmanagedType.LPStr)] string json_user_id_array,
        TIMCommCallback callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGetMyFollowingList(
        [MarshalAs(UnmanagedType.LPStr)] string json_get_following_list_param,
        TIMCommCallback callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGetMyFollowersList(
        [MarshalAs(UnmanagedType.LPStr)] string json_get_followers_list_param,
        TIMCommCallback callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGetMutualFollowersList(
        [MarshalAs(UnmanagedType.LPStr)] string json_get_mutual_followers_list_param,
        TIMCommCallback callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGetUserFollowInfo(
        [MarshalAs(UnmanagedType.LPStr)] string json_user_id_array,
        TIMCommCallback callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMCheckFollowType(
        [MarshalAs(UnmanagedType.LPStr)] string json_user_id_array,
        TIMCommCallback callback,
        IntPtr user_data);
}
