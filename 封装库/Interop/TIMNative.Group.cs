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

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGroupModifyGroupInfo(
        [MarshalAs(UnmanagedType.LPStr)] string json_group_modifyinfo_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGroupModifyMemberInfo(
        [MarshalAs(UnmanagedType.LPStr)] string json_group_modifymeminfo_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGroupSearchGroups(
        [MarshalAs(UnmanagedType.LPStr)] string json_search_groups_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGroupSearchCloudGroups(
        [MarshalAs(UnmanagedType.LPStr)] string json_search_groups_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGroupGetJoinedCommunityList(
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGroupSearchGroupMembers(
        [MarshalAs(UnmanagedType.LPStr)] string json_search_group_members_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGroupSearchCloudGroupMembers(
        [MarshalAs(UnmanagedType.LPStr)] string json_search_group_members_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGroupMarkGroupMemberList(
        [MarshalAs(UnmanagedType.LPStr)] string group_id,
        [MarshalAs(UnmanagedType.LPStr)] string json_identifier_array,
        uint mark_type,
        bool enable_mark,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGroupGetPendencyList(
        [MarshalAs(UnmanagedType.LPStr)] string json_group_getpendence_list_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGroupHandlePendency(
        [MarshalAs(UnmanagedType.LPStr)] string json_group_handle_pendency_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGroupReportPendencyReaded(
        ulong time_stamp,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGroupInitGroupAttributes(
        [MarshalAs(UnmanagedType.LPStr)] string group_id,
        [MarshalAs(UnmanagedType.LPStr)] string json_group_attributes,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGroupSetGroupAttributes(
        [MarshalAs(UnmanagedType.LPStr)] string group_id,
        [MarshalAs(UnmanagedType.LPStr)] string json_group_attributes,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGroupDeleteGroupAttributes(
        [MarshalAs(UnmanagedType.LPStr)] string group_id,
        [MarshalAs(UnmanagedType.LPStr)] string json_keys,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGroupGetGroupAttributes(
        [MarshalAs(UnmanagedType.LPStr)] string group_id,
        [MarshalAs(UnmanagedType.LPStr)] string json_keys,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGroupGetOnlineMemberCount(
        [MarshalAs(UnmanagedType.LPStr)] string group_id,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGroupSetGroupCounters(
        [MarshalAs(UnmanagedType.LPStr)] string group_id,
        [MarshalAs(UnmanagedType.LPStr)] string json_group_counters,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGroupGetGroupCounters(
        [MarshalAs(UnmanagedType.LPStr)] string group_id,
        [MarshalAs(UnmanagedType.LPStr)] string json_group_counter_keys,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGroupIncreaseGroupCounter(
        [MarshalAs(UnmanagedType.LPStr)] string group_id,
        [MarshalAs(UnmanagedType.LPStr)] string group_counter_key,
        long value,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGroupDecreaseGroupCounter(
        [MarshalAs(UnmanagedType.LPStr)] string group_id,
        [MarshalAs(UnmanagedType.LPStr)] string group_counter_key,
        long value,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGroupCreateTopicInCommunity(
        [MarshalAs(UnmanagedType.LPStr)] string group_id,
        [MarshalAs(UnmanagedType.LPStr)] string json_topic_info,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGroupDeleteTopicFromCommunity(
        [MarshalAs(UnmanagedType.LPStr)] string group_id,
        [MarshalAs(UnmanagedType.LPStr)] string json_topic_id_array,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGroupSetTopicInfo(
        [MarshalAs(UnmanagedType.LPStr)] string json_topic_info,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGroupGetTopicInfoList(
        [MarshalAs(UnmanagedType.LPStr)] string group_id,
        [MarshalAs(UnmanagedType.LPStr)] string json_topic_id_array,
        IntPtr callback,
        IntPtr user_data);
}
