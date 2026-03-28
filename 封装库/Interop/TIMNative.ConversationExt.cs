using System.Runtime.InteropServices;

namespace TencentIM.Native.Interop;

/// <summary>
/// 会话相关接口扩展
/// </summary>
public static partial class TIMNative
{
    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMConvGetConvInfo(
        [MarshalAs(UnmanagedType.LPStr)] string json_get_conv_list_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMConvGetConversationListByFilter(
        [MarshalAs(UnmanagedType.LPStr)] string json_get_conversation_list_by_filter_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMConvDeleteConversationList(
        [MarshalAs(UnmanagedType.LPStr)] string json_conv_id_array,
        bool clear_message,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMConvSetDraft(
        [MarshalAs(UnmanagedType.LPStr)] string conv_id,
        int conv_type,
        [MarshalAs(UnmanagedType.LPStr)] string json_draft_param);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMConvCancelDraft(
        [MarshalAs(UnmanagedType.LPStr)] string conv_id,
        int conv_type);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMConvSetConversationCustomData(
        [MarshalAs(UnmanagedType.LPStr)] string json_conversation_array,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMConvPinConversation(
        [MarshalAs(UnmanagedType.LPStr)] string conv_id,
        int conv_type,
        bool is_pinned,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMConvMarkConversation(
        [MarshalAs(UnmanagedType.LPStr)] string json_conversation_id_array,
        ulong mark_type,
        bool enable_mark,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int TIMConvGetTotalUnreadMessageCount(
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMConvGetUnreadMessageCountByFilter(
        [MarshalAs(UnmanagedType.LPStr)] string json_filter,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMConvSubscribeUnreadMessageCountByFilter(
        [MarshalAs(UnmanagedType.LPStr)] string json_filter);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMConvUnsubscribeUnreadMessageCountByFilter(
        [MarshalAs(UnmanagedType.LPStr)] string json_filter);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMConvCleanConversationUnreadMessageCount(
        [MarshalAs(UnmanagedType.LPStr)] string conv_id,
        int conv_type,
        ulong clean_timestamp,
        ulong clean_sequence,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMConvCreateConversationGroup(
        [MarshalAs(UnmanagedType.LPStr)] string group_name,
        [MarshalAs(UnmanagedType.LPStr)] string json_conversation_id_array,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int TIMConvGetConversationGroupList(
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMConvDeleteConversationGroup(
        [MarshalAs(UnmanagedType.LPStr)] string group_name,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMConvRenameConversationGroup(
        [MarshalAs(UnmanagedType.LPStr)] string old_name,
        [MarshalAs(UnmanagedType.LPStr)] string new_name,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMConvAddConversationsToGroup(
        [MarshalAs(UnmanagedType.LPStr)] string group_name,
        [MarshalAs(UnmanagedType.LPStr)] string json_conversation_id_array,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMConvDeleteConversationsFromGroup(
        [MarshalAs(UnmanagedType.LPStr)] string group_name,
        [MarshalAs(UnmanagedType.LPStr)] string json_conversation_id_array,
        IntPtr callback,
        IntPtr user_data);
}
