using System.Runtime.InteropServices;

namespace TencentIM.Native.Interop;

/// <summary>
/// 会话管理相关接口
/// </summary>
public static partial class TIMNative
{
    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMConvGetConvList(
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMConvDelete(
        [MarshalAs(UnmanagedType.LPStr)] string conv_id,
        int conv_type,
        IntPtr callback,
        IntPtr user_data);
}
