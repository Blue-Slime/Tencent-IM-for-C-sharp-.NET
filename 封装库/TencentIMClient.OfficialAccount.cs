using TencentIM.Native.Interop;

namespace TencentIM.Native;

/// <summary>
/// 公众号相关接口
/// </summary>
public partial class TencentIMClient
{
    public async Task<bool> TIMSubscribeOfficialAccount(string officialAccountId)
        => await Task.Run(() => TIMNative.TIMSubscribeOfficialAccount(officialAccountId, (TIMCommCallback?)null, IntPtr.Zero) == 0);

    public async Task<bool> TIMUnsubscribeOfficialAccount(string officialAccountId)
        => await Task.Run(() => TIMNative.TIMUnsubscribeOfficialAccount(officialAccountId, (TIMCommCallback?)null, IntPtr.Zero) == 0);

    public async Task<bool> TIMGetOfficialAccountsInfo(string jsonOfficialAccountIdArray)
        => await Task.Run(() => TIMNative.TIMGetOfficialAccountsInfo(jsonOfficialAccountIdArray, (TIMCommCallback?)null, IntPtr.Zero) == 0);
}
