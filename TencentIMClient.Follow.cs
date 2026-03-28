namespace TencentIM.Native;

/// <summary>
/// 关注与粉丝相关接口
/// </summary>
public partial class TencentIMClient
{
    public async Task<bool> TIMFollowUser(string jsonUserIdArray)
        => await Task.Run(() => TIMNative.TIMFollowUser(jsonUserIdArray, IntPtr.Zero, IntPtr.Zero) == 0);

    public async Task<bool> TIMUnfollowUser(string jsonUserIdArray)
        => await Task.Run(() => TIMNative.TIMUnfollowUser(jsonUserIdArray, IntPtr.Zero, IntPtr.Zero) == 0);

    public async Task<bool> TIMGetMyFollowingList(string jsonGetFollowingListParam)
        => await Task.Run(() => TIMNative.TIMGetMyFollowingList(jsonGetFollowingListParam, IntPtr.Zero, IntPtr.Zero) == 0);

    public async Task<bool> TIMGetMyFollowersList(string jsonGetFollowersListParam)
        => await Task.Run(() => TIMNative.TIMGetMyFollowersList(jsonGetFollowersListParam, IntPtr.Zero, IntPtr.Zero) == 0);

    public async Task<bool> TIMGetMutualFollowersList(string jsonGetMutualFollowersListParam)
        => await Task.Run(() => TIMNative.TIMGetMutualFollowersList(jsonGetMutualFollowersListParam, IntPtr.Zero, IntPtr.Zero) == 0);

    public async Task<bool> TIMGetUserFollowInfo(string jsonUserIdArray)
        => await Task.Run(() => TIMNative.TIMGetUserFollowInfo(jsonUserIdArray, IntPtr.Zero, IntPtr.Zero) == 0);

    public async Task<bool> TIMCheckFollowType(string jsonUserIdArray)
        => await Task.Run(() => TIMNative.TIMCheckFollowType(jsonUserIdArray, IntPtr.Zero, IntPtr.Zero) == 0);
}
