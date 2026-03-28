using System.Runtime.InteropServices;

namespace TencentIM.Native.Interop;

/// <summary>
/// 用户状态相关接口
/// </summary>
public static partial class TIMNative
{
    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGetUserStatus(
        [MarshalAs(UnmanagedType.LPStr)] string json_identifier_array,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMSetSelfStatus(
        [MarshalAs(UnmanagedType.LPStr)] string json_current_user_status,
        IntPtr callback,
        IntPtr user_data);
}
