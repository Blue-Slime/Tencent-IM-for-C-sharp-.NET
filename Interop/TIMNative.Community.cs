using System.Runtime.InteropServices;

namespace TencentIM.Native.Interop;

/// <summary>
/// 社群话题相关接口
/// </summary>
public static partial class TIMNative
{
    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMCommunityCreate(
        [MarshalAs(UnmanagedType.LPStr)] string json_community_param,
        TIMCommCallback callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int TIMCommunityGetJoinedCommunityList(
        TIMCommCallback callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMCommunityCreateTopicInCommunity(
        [MarshalAs(UnmanagedType.LPStr)] string group_id,
        [MarshalAs(UnmanagedType.LPStr)] string json_topic_info,
        TIMCommCallback callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMCommunityDeleteTopicFromCommunity(
        [MarshalAs(UnmanagedType.LPStr)] string group_id,
        [MarshalAs(UnmanagedType.LPStr)] string json_topic_id_array,
        TIMCommCallback callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMCommunitySetTopicInfo(
        [MarshalAs(UnmanagedType.LPStr)] string json_topic_info,
        TIMCommCallback callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMCommunityGetTopicInfoList(
        [MarshalAs(UnmanagedType.LPStr)] string group_id,
        [MarshalAs(UnmanagedType.LPStr)] string json_topic_id_array,
        TIMCommCallback callback,
        IntPtr user_data);
}
