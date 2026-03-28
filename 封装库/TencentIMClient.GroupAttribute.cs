using TencentIM.Native.Interop;

namespace TencentIM.Native;

/// <summary>
/// 群组属性与计数器扩展
/// </summary>
public partial class TencentIMClient
{
    public async Task<bool> TIMGroupInitGroupAttributes(string groupId, string jsonGroupAttributes) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMGroupInitGroupAttributes(groupId, jsonGroupAttributes, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMGroupSetGroupAttributes(string groupId, string jsonGroupAttributes) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMGroupSetGroupAttributes(groupId, jsonGroupAttributes, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMGroupDeleteGroupAttributes(string groupId, string jsonKeys) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMGroupDeleteGroupAttributes(groupId, jsonKeys, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMGroupGetGroupAttributes(string groupId, string jsonKeys) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMGroupGetGroupAttributes(groupId, jsonKeys, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMGroupGetOnlineMemberCount(string groupId) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMGroupGetOnlineMemberCount(groupId, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMGroupSetGroupCounters(string groupId, string jsonGroupCounters) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMGroupSetGroupCounters(groupId, jsonGroupCounters, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMGroupGetGroupCounters(string groupId, string jsonGroupCounterKeys) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMGroupGetGroupCounters(groupId, jsonGroupCounterKeys, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMGroupIncreaseGroupCounter(string groupId, string groupCounterKey, long value) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMGroupIncreaseGroupCounter(groupId, groupCounterKey, value, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMGroupDecreaseGroupCounter(string groupId, string groupCounterKey, long value) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMGroupDecreaseGroupCounter(groupId, groupCounterKey, value, IntPtr.Zero, IntPtr.Zero) == 0;
}
