using System.Runtime.InteropServices;

namespace TencentIM.Native.Interop;

/// <summary>
/// 公众号相关接口
/// </summary>
public static partial class TIMNative
{
    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMSubscribeOfficialAccount(
        [MarshalAs(UnmanagedType.LPStr)] string official_account_id,
        TIMCommCallback callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMUnsubscribeOfficialAccount(
        [MarshalAs(UnmanagedType.LPStr)] string official_account_id,
        TIMCommCallback callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int TIMGetOfficialAccountsInfo(
        [MarshalAs(UnmanagedType.LPStr)] string json_official_account_id_array,
        TIMCommCallback callback,
        IntPtr user_data);
}
