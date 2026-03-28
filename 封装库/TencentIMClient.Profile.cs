using TencentIM.Native.Interop;

namespace TencentIM.Native;

/// <summary>
/// 用户资料扩展
/// </summary>
public partial class TencentIMClient
{
    /// <summary>
    /// 获取用户资料 (对应 TIMProfileGetUserProfileList)
    /// </summary>
    public async Task<bool> TIMProfileGetUserProfileList(string jsonGetUserProfileListParam)
    {
        if (!_isLoggedIn)
            throw new InvalidOperationException("Not logged in");

        var ret = TIMNative.TIMProfileGetUserProfileList(jsonGetUserProfileListParam, IntPtr.Zero, IntPtr.Zero);
        return ret == 0;
    }

    /// <summary>
    /// 修改自己的资料 (对应 TIMProfileModifySelfUserProfile)
    /// </summary>
    public async Task<bool> TIMProfileModifySelfUserProfile(string jsonModifySelfUserProfileParam)
    {
        if (!_isLoggedIn)
            throw new InvalidOperationException("Not logged in");

        var ret = TIMNative.TIMProfileModifySelfUserProfile(jsonModifySelfUserProfileParam, IntPtr.Zero, IntPtr.Zero);
        return ret == 0;
    }

    public async Task<bool> TIMSubscribeUserInfo(string jsonIdentifierArray) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMSubscribeUserInfo(jsonIdentifierArray, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMUnsubscribeUserInfo(string jsonIdentifierArray) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMUnsubscribeUserInfo(jsonIdentifierArray, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMSearchUsers(string jsonSearchUsersParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMSearchUsers(jsonSearchUsersParam, IntPtr.Zero, IntPtr.Zero) == 0;
}
