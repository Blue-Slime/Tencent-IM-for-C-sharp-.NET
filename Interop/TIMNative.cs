using System.Runtime.InteropServices;

namespace TencentIM.Native.Interop;

/// <summary>
/// 腾讯云IM C接口的P/Invoke声明
/// </summary>
public static partial class TIMNative
{
    private const string DllName = "ImSDK.dll";

    // ========== 初始化相关 ==========

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMInit(long sdk_app_id, IntPtr json_sdk_config);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int TIMUninit();

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern IntPtr TIMGetSDKVersion();

    // ========== 登录相关 ==========

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMLogin(
        [MarshalAs(UnmanagedType.LPStr)] string user_id,
        [MarshalAs(UnmanagedType.LPStr)] string user_sig,
        IntPtr callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int TIMLogout(IntPtr callback, IntPtr user_data);
}
