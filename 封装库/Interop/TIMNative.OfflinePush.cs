using System.Runtime.InteropServices;

namespace TencentIM.Native.Interop;

/// <summary>
/// 离线推送相关接口
/// </summary>
public static partial class TIMNative
{
    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMMsgSetOfflinePushToken(
        [MarshalAs(UnmanagedType.LPStr)] string json_token_param,
        TIMCommCallback callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int TIMMsgDoBackground(
        int unread_count,
        TIMCommCallback callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int TIMMsgDoForeground(
        TIMCommCallback callback,
        IntPtr user_data);
}
