using System.Text.Json;
using TencentIM.Native.Interop;

namespace TencentIM.Native;

/// <summary>
/// 群组管理扩展
/// </summary>
public partial class TencentIMClient
{
    /// <summary>
    /// 创建群组 (对应 TIMGroupCreate)
    /// </summary>
    public async Task<string?> TIMGroupCreate(string groupName, string groupType = "Public")
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
    /// 加入群组 (对应 TIMGroupJoin)
    /// </summary>
    public async Task<bool> TIMGroupJoin(string groupId, string helloMsg = "")
    {
        if (!_isLoggedIn)
            throw new InvalidOperationException("Not logged in");

        var ret = TIMNative.TIMGroupJoin(groupId, helloMsg, IntPtr.Zero, IntPtr.Zero);
        return ret == 0;
    }

    /// <summary>
    /// 退出群组 (对应 TIMGroupQuit)
    /// </summary>
    public async Task<bool> TIMGroupQuit(string groupId)
    {
        if (!_isLoggedIn)
            throw new InvalidOperationException("Not logged in");

        var ret = TIMNative.TIMGroupQuit(groupId, IntPtr.Zero, IntPtr.Zero);
        return ret == 0;
    }

    /// <summary>
    /// 解散群组 (对应 TIMGroupDelete)
    /// </summary>
    public async Task<bool> TIMGroupDelete(string groupId)
    {
        if (!_isLoggedIn)
            throw new InvalidOperationException("Not logged in");

        var ret = TIMNative.TIMGroupDelete(groupId, IntPtr.Zero, IntPtr.Zero);
        return ret == 0;
    }

    /// <summary>
    /// 邀请成员加入群组 (对应 TIMGroupInviteMember)
    /// </summary>
    public async Task<bool> TIMGroupInviteMember(string groupId, string[] userIds)
    {
        if (!_isLoggedIn)
            throw new InvalidOperationException("Not logged in");

        var param = new
        {
            group_invite_member_param_group_id = groupId,
            group_invite_member_param_identifier_array = userIds
        };

        var json = JsonSerializer.Serialize(param);
        var ret = TIMNative.TIMGroupInviteMember(json, IntPtr.Zero, IntPtr.Zero);
        return ret == 0;
    }

    /// <summary>
    /// 删除群组成员 (对应 TIMGroupDeleteMember)
    /// </summary>
    public async Task<bool> TIMGroupDeleteMember(string groupId, string[] userIds)
    {
        if (!_isLoggedIn)
            throw new InvalidOperationException("Not logged in");

        var param = new
        {
            group_delete_member_param_group_id = groupId,
            group_delete_member_param_identifier_array = userIds
        };

        var json = JsonSerializer.Serialize(param);
        var ret = TIMNative.TIMGroupDeleteMember(json, IntPtr.Zero, IntPtr.Zero);
        return ret == 0;
    }

    /// <summary>
    /// 获取已加入的群组列表 (对应 TIMGroupGetJoinedGroupList)
    /// </summary>
    public async Task<bool> TIMGroupGetJoinedGroupList()
    {
        if (!_isLoggedIn)
            throw new InvalidOperationException("Not logged in");

        var ret = TIMNative.TIMGroupGetJoinedGroupList(IntPtr.Zero, IntPtr.Zero);
        return ret == 0;
    }

    /// <summary>
    /// 获取群成员信息列表 (对应 TIMGroupGetMemberInfoList)
    /// </summary>
    public async Task<bool> TIMGroupGetMemberInfoList(string groupId, string jsonGetMemberInfoParam)
    {
        if (!_isLoggedIn)
            throw new InvalidOperationException("Not logged in");

        var ret = TIMNative.TIMGroupGetMemberInfoList(groupId, jsonGetMemberInfoParam, IntPtr.Zero, IntPtr.Zero);
        return ret == 0;
    }

    /// <summary>
    /// 获取群组信息列表 (对应 TIMGroupGetGroupInfoList)
    /// </summary>
    public async Task<bool> TIMGroupGetGroupInfoList(string jsonGroupIdList)
    {
        if (!_isLoggedIn)
            throw new InvalidOperationException("Not logged in");

        var ret = TIMNative.TIMGroupGetGroupInfoList(jsonGroupIdList, IntPtr.Zero, IntPtr.Zero);
        return ret == 0;
    }
}
