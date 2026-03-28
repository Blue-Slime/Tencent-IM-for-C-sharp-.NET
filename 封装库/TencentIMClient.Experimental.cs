using TencentIM.Native.Interop;

namespace TencentIM.Native;

/// <summary>
/// 实验性接口
/// </summary>
public partial class TencentIMClient
{
    public async Task<bool> callExperimentalAPI(string jsonParam)
        => await Task.Run(() => TIMNative.callExperimentalAPI(jsonParam, (TIMCommCallback?)null, IntPtr.Zero) == 0);

    private TIMExperimentalAPICallback? _experimentalApiCb;
    public event Action<string>? OnExperimentalAPIRequest;

    public void TIMSetExperimentalAPIReqeustCallback()
    {
        _experimentalApiCb = (json, _) => OnExperimentalAPIRequest?.Invoke(json);
        TIMNative.TIMSetExperimentalAPIReqeustCallback(_experimentalApiCb, IntPtr.Zero);
    }
}
