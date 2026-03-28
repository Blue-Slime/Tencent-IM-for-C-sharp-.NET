using System.Runtime.InteropServices;

namespace TencentIM.Native.Interop;

/// <summary>
/// 实验性接口
/// </summary>
public static partial class TIMNative
{
    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int callExperimentalAPI(
        [MarshalAs(UnmanagedType.LPStr)] string json_param,
        TIMCommCallback callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetExperimentalAPIReqeustCallback(
        TIMExperimentalAPICallback callback,
        IntPtr user_data);
}

/// <summary>
/// 实验性API回调委托
/// </summary>
[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
public delegate void TIMExperimentalAPICallback(
    [MarshalAs(UnmanagedType.LPStr)] string json_param,
    IntPtr user_data);
