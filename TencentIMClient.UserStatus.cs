using System.Text.Json;
using TencentIM.Native.Interop;

namespace TencentIM.Native;

/// <summary>
/// 用户状态扩展
/// </summary>
public partial class TencentIMClient
{
    /// <summary>
    /// 获取用户状态 (对应 TIMGetUserStatus)
    /// </summary>
    public async Task<bool> TIMGetUserStatus(string jsonIdentifierArray)
    {
        if (!_isLoggedIn)
            throw new InvalidOperationException("Not logged in");

        var ret = TIMNative.TIMGetUserStatus(jsonIdentifierArray, IntPtr.Zero, IntPtr.Zero);
        return ret == 0;
    }

    /// <summary>
    /// 设置自己的状态 (对应 TIMSetSelfStatus)
    /// </summary>
    public async Task<bool> TIMSetSelfStatus(string jsonCurrentUserStatus)
    {
        if (!_isLoggedIn)
            throw new InvalidOperationException("Not logged in");

        var ret = TIMNative.TIMSetSelfStatus(jsonCurrentUserStatus, IntPtr.Zero, IntPtr.Zero);
        return ret == 0;
    }
}
