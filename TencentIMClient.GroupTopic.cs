using TencentIM.Native.Interop;

namespace TencentIM.Native;

/// <summary>
/// 群组话题扩展
/// </summary>
public partial class TencentIMClient
{
    public async Task<bool> TIMGroupCreateTopicInCommunity(string groupId, string jsonTopicInfo) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMGroupCreateTopicInCommunity(groupId, jsonTopicInfo, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMGroupDeleteTopicFromCommunity(string groupId, string jsonTopicIdArray) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMGroupDeleteTopicFromCommunity(groupId, jsonTopicIdArray, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMGroupSetTopicInfo(string jsonTopicInfo) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMGroupSetTopicInfo(jsonTopicInfo, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMGroupGetTopicInfoList(string groupId, string jsonTopicIdArray) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMGroupGetTopicInfoList(groupId, jsonTopicIdArray, IntPtr.Zero, IntPtr.Zero) == 0;
}
