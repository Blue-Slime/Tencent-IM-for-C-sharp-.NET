using TencentIM.Native.Interop;

namespace TencentIM.Native;

/// <summary>
/// SDK配置扩展
/// </summary>
public partial class TencentIMClient
{
    public async Task<bool> TIMSetConfig(string jsonConfig) => TIMNative.TIMSetConfig(jsonConfig, IntPtr.Zero, IntPtr.Zero) == 0;
}
