using System.Runtime.InteropServices;

namespace TencentIM.Native.Interop;

/// <summary>
/// 消息相关的P/Invoke声明
/// </summary>
public static partial class TIMNative
{
    // ========== 消息发送 ==========

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgSendMessage(
        [MarshalAs(UnmanagedType.LPStr)] string conv_id,
        int conv_type,
        [MarshalAs(UnmanagedType.LPStr)] string json_msg_param,
        IntPtr callback,
        IntPtr user_data);

    // ========== 消息回调 ==========

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMAddRecvNewMsgCallback(
        TIMRecvNewMsgCallback callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMRemoveRecvNewMsgCallback(
        TIMRecvNewMsgCallback callback);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgRevoke(
        [MarshalAs(UnmanagedType.LPStr)] string conv_id,
        int conv_type,
        [MarshalAs(UnmanagedType.LPStr)] string json_msg_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgDelete(
        [MarshalAs(UnmanagedType.LPStr)] string conv_id,
        int conv_type,
        [MarshalAs(UnmanagedType.LPStr)] string json_msgdel_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgGetMsgList(
        [MarshalAs(UnmanagedType.LPStr)] string conv_id,
        int conv_type,
        [MarshalAs(UnmanagedType.LPStr)] string json_get_msg_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgDownloadElemToPath(
        [MarshalAs(UnmanagedType.LPStr)] string json_download_elem_param,
        [MarshalAs(UnmanagedType.LPStr)] string path,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgSetC2CReceiveMessageOpt(
        [MarshalAs(UnmanagedType.LPStr)] string json_identifier_array,
        int opt,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgGetC2CReceiveMessageOpt(
        [MarshalAs(UnmanagedType.LPStr)] string json_identifier_array,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgCancelSend(
        [MarshalAs(UnmanagedType.LPStr)] string conv_id,
        int conv_type,
        [MarshalAs(UnmanagedType.LPStr)] string json_msg_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgBatchSend(
        [MarshalAs(UnmanagedType.LPStr)] string json_batch_send_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgModifyMessage(
        [MarshalAs(UnmanagedType.LPStr)] string json_msg_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgListDelete(
        [MarshalAs(UnmanagedType.LPStr)] string conv_id,
        int conv_type,
        [MarshalAs(UnmanagedType.LPStr)] string json_msg_array,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgClearHistoryMessage(
        [MarshalAs(UnmanagedType.LPStr)] string conv_id,
        int conv_type,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgSaveMsg(
        [MarshalAs(UnmanagedType.LPStr)] string conv_id,
        int conv_type,
        [MarshalAs(UnmanagedType.LPStr)] string json_msg_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgImportMsgList(
        [MarshalAs(UnmanagedType.LPStr)] string conv_id,
        int conv_type,
        [MarshalAs(UnmanagedType.LPStr)] string json_msg_array,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgFindMessages(
        [MarshalAs(UnmanagedType.LPStr)] string json_message_id_array,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgFindByMsgLocatorList(
        [MarshalAs(UnmanagedType.LPStr)] string conv_id,
        int conv_type,
        [MarshalAs(UnmanagedType.LPStr)] string json_msg_locator_array,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgDownloadMergerMessage(
        [MarshalAs(UnmanagedType.LPStr)] string json_msg_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgSetLocalCustomData(
        [MarshalAs(UnmanagedType.LPStr)] string json_msg_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgSearchLocalMessages(
        [MarshalAs(UnmanagedType.LPStr)] string json_search_message_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgSearchCloudMessages(
        [MarshalAs(UnmanagedType.LPStr)] string json_search_message_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgSetGroupReceiveMessageOpt(
        [MarshalAs(UnmanagedType.LPStr)] string group_id,
        int opt,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgSetAllReceiveMessageOpt(
        int opt,
        int start_hour,
        int start_minute,
        int duration,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgSetAllReceiveMessageOpt2(
        int opt,
        int start_time_stamp,
        int duration,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgGetAllReceiveMessageOpt(
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgSendMessageReadReceipts(
        [MarshalAs(UnmanagedType.LPStr)] string json_msg_array,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgGetMessageReadReceipts(
        [MarshalAs(UnmanagedType.LPStr)] string json_msg_array,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgGetGroupMessageReadMemberList(
        [MarshalAs(UnmanagedType.LPStr)] string json_msg_param,
        int filter,
        ulong next_seq,
        int count,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgSetMessageExtensions(
        [MarshalAs(UnmanagedType.LPStr)] string json_msg_param,
        [MarshalAs(UnmanagedType.LPStr)] string json_extension_array,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgGetMessageExtensions(
        [MarshalAs(UnmanagedType.LPStr)] string json_msg_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgDeleteMessageExtensions(
        [MarshalAs(UnmanagedType.LPStr)] string json_msg_param,
        [MarshalAs(UnmanagedType.LPStr)] string json_extension_key_array,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgAddMessageReaction(
        [MarshalAs(UnmanagedType.LPStr)] string json_msg_param,
        [MarshalAs(UnmanagedType.LPStr)] string reaction_id,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgRemoveMessageReaction(
        [MarshalAs(UnmanagedType.LPStr)] string json_msg_param,
        [MarshalAs(UnmanagedType.LPStr)] string reaction_id,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgGetMessageReactions(
        [MarshalAs(UnmanagedType.LPStr)] string json_msg_array,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgGetAllUserListOfMessageReaction(
        [MarshalAs(UnmanagedType.LPStr)] string json_msg_param,
        [MarshalAs(UnmanagedType.LPStr)] string reaction_id,
        uint next_seq,
        uint count,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgTranslateText(
        [MarshalAs(UnmanagedType.LPStr)] string json_source_text_array,
        [MarshalAs(UnmanagedType.LPStr)] string target_language,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMPinGroupMessage(
        [MarshalAs(UnmanagedType.LPStr)] string group_id,
        [MarshalAs(UnmanagedType.LPStr)] string json_msg_param,
        bool is_pin,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGetPinnedMessageList(
        [MarshalAs(UnmanagedType.LPStr)] string group_id,
        IntPtr callback,
        IntPtr user_data);
}

/// <summary>
/// 接收消息回调委托
/// </summary>
[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
public delegate void TIMRecvNewMsgCallback(
    [MarshalAs(UnmanagedType.LPStr)] string json_msg_array,
    IntPtr user_data);
