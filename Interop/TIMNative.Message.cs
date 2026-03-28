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
}

/// <summary>
/// 接收消息回调委托
/// </summary>
[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
public delegate void TIMRecvNewMsgCallback(
    [MarshalAs(UnmanagedType.LPStr)] string json_msg_array,
    IntPtr user_data);
