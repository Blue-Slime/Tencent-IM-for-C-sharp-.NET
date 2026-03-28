using System.Text.Json;
using TencentIM.Native.Interop;

namespace TencentIM.Native;

/// <summary>
/// 好友管理扩展
/// </summary>
public partial class TencentIMClient
{
    /// <summary>
    /// 添加好友
    /// </summary>
    public async Task<bool> AddFriendAsync(string userId, string remark = "")
    {
        if (!_isLoggedIn)
            throw new InvalidOperationException("Not logged in");

        var param = new
        {
            friendship_add_friend_param_identifier = userId,
            friendship_add_friend_param_remark = remark,
            friendship_add_friend_param_add_type = 1 // 单向添加
        };

        var json = JsonSerializer.Serialize(param);
        var ret = TIMNative.TIMFriendshipAddFriend(json, IntPtr.Zero, IntPtr.Zero);
        return ret == 0;
    }

    /// <summary>
    /// 删除好友
    /// </summary>
    public async Task<bool> DeleteFriendAsync(string userId)
    {
        if (!_isLoggedIn)
            throw new InvalidOperationException("Not logged in");

        var param = new
        {
            friendship_delete_friend_param_identifier_array = new[] { userId }
        };

        var json = JsonSerializer.Serialize(param);
        var ret = TIMNative.TIMFriendshipDeleteFriend(json, IntPtr.Zero, IntPtr.Zero);
        return ret == 0;
    }

    /// <summary>
    /// 获取好友列表
    /// </summary>
    public async Task<bool> GetFriendListAsync()
    {
        if (!_isLoggedIn)
            throw new InvalidOperationException("Not logged in");

        var ret = TIMNative.TIMFriendshipGetFriendProfileList(IntPtr.Zero, IntPtr.Zero);
        return ret == 0;
    }
}
