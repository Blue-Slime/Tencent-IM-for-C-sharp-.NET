using System.Text.Json;
using TencentIM.Native.Interop;

namespace TencentIM.Native;

/// <summary>
/// 群组管理扩展
/// </summary>
public partial class TencentIMClient
{
    /// <summary>
    /// 创建群组
    /// </summary>
    public async Task<string?> CreateGroupAsync(string groupName, string groupType = "Public")
    {
        if (!_isLoggedIn)
            throw new InvalidOperationException("Not logged in");

        var param = new
        {
            create_group_param_group_name = groupName,
            create_group_param_group_type = groupType
        };

        var json = JsonSerializer.Serialize(param);
        var ret = TIMNative.TIMGroupCreate(json, IntPtr.Zero, IntPtr.Zero);

        return ret == 0 ? "group_id" : null;
    }

    /// <summary>
    /// 加入群组
    /// </summary>
    public async Task<bool> JoinGroupAsync(string groupId, string helloMsg = "")
    {
        if (!_isLoggedIn)
            throw new InvalidOperationException("Not logged in");

        var ret = TIMNative.TIMGroupJoin(groupId, helloMsg, IntPtr.Zero, IntPtr.Zero);
        return ret == 0;
    }

    /// <summary>
    /// 退出群组
    /// </summary>
    public async Task<bool> QuitGroupAsync(string groupId)
    {
        if (!_isLoggedIn)
            throw new InvalidOperationException("Not logged in");

        var ret = TIMNative.TIMGroupQuit(groupId, IntPtr.Zero, IntPtr.Zero);
        return ret == 0;
    }
}
