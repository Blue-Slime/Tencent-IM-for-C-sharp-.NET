using System.Runtime.InteropServices;

namespace TencentIM.Native.Interop;

/// <summary>
/// 信令相关接口
/// </summary>
public static partial class TIMNative
{
    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMSignalingInvite(
        [MarshalAs(UnmanagedType.LPStr)] string json_invite_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMSignalingInviteInGroup(
        [MarshalAs(UnmanagedType.LPStr)] string json_invite_in_group_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMSignalingCancel(
        [MarshalAs(UnmanagedType.LPStr)] string json_cancel_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMSignalingAccept(
        [MarshalAs(UnmanagedType.LPStr)] string json_accept_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMSignalingReject(
        [MarshalAs(UnmanagedType.LPStr)] string json_reject_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMSignalingGetSignalingInfo(
        [MarshalAs(UnmanagedType.LPStr)] string json_msg_param,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMSignalingAddInvitedSignaling(
        [MarshalAs(UnmanagedType.LPStr)] string json_signaling_info,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMSignalingModifyInvitation(
        [MarshalAs(UnmanagedType.LPStr)] string json_modify_invitation_param,
        IntPtr callback,
        IntPtr user_data);
}
