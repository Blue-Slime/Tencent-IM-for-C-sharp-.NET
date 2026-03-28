using TencentIM.Native.Interop;

namespace TencentIM.Native;

/// <summary>
/// 社群话题相关接口
/// </summary>
public partial class TencentIMClient
{
    public async Task<bool> TIMCommunityCreate(string jsonCommunityParam)
        => await Task.Run(() => TIMNative.TIMCommunityCreate(jsonCommunityParam, (TIMCommCallback?)null, IntPtr.Zero) == 0);

    public async Task<bool> TIMCommunityGetJoinedCommunityList()
        => await Task.Run(() => TIMNative.TIMCommunityGetJoinedCommunityList((TIMCommCallback?)null, IntPtr.Zero) == 0);

    public async Task<bool> TIMCommunityCreateTopicInCommunity(string groupId, string jsonTopicInfo)
        => await Task.Run(() => TIMNative.TIMCommunityCreateTopicInCommunity(groupId, jsonTopicInfo, (TIMCommCallback?)null, IntPtr.Zero) == 0);

    public async Task<bool> TIMCommunityDeleteTopicFromCommunity(string groupId, string jsonTopicIdArray)
        => await Task.Run(() => TIMNative.TIMCommunityDeleteTopicFromCommunity(groupId, jsonTopicIdArray, (TIMCommCallback?)null, IntPtr.Zero) == 0);

    public async Task<bool> TIMCommunitySetTopicInfo(string jsonTopicInfo)
        => await Task.Run(() => TIMNative.TIMCommunitySetTopicInfo(jsonTopicInfo, (TIMCommCallback?)null, IntPtr.Zero) == 0);

    public async Task<bool> TIMCommunityGetTopicInfoList(string groupId, string jsonTopicIdArray)
        => await Task.Run(() => TIMNative.TIMCommunityGetTopicInfoList(groupId, jsonTopicIdArray, (TIMCommCallback?)null, IntPtr.Zero) == 0);
}
