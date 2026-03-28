using System.Runtime.InteropServices;

namespace TencentIM.Native.Interop;

/// <summary>
/// 事件回调相关接口
/// </summary>
public static partial class TIMNative
{
    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetMsgRevokeCallback(
        TIMMsgRevokeCallback callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetGroupTipsEventCallback(
        TIMGroupTipsEventCallback callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetConvEventCallback(
        TIMConvEventCallback callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetMsgUpdateCallback(
        TIMMsgUpdateCallback callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetGroupAttributeChangedCallback(
        TIMGroupAttributeChangedCallback callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetMsgReadedReceiptCallback(
        TIMMsgCallback callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetMsgElemUploadProgressCallback(
        TIMMsgCallback callback,
        IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetMsgModifiedCallback(
        TIMMsgCallback callback,
        IntPtr user_data);
}

/// <summary>
/// 通用消息回调委托
/// </summary>
[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
public delegate void TIMMsgCallback(
    [MarshalAs(UnmanagedType.LPStr)] string json_msg_array,
    IntPtr user_data);

/// <summary>
/// 网络状态回调委托
/// </summary>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void TIMNetworkStatusCallback(
    int status,
    int code,
    [MarshalAs(UnmanagedType.LPStr)] string desc,
    IntPtr user_data);

/// <summary>
/// 被踢下线回调委托
/// </summary>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void TIMKickedOfflineCallback(IntPtr user_data);

/// <summary>
/// UserSig过期回调委托
/// </summary>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void TIMUserSigExpiredCallback(IntPtr user_data);

/// <summary>
/// 日志回调委托
/// </summary>
[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
public delegate void TIMLogCallback(
    int level,
    [MarshalAs(UnmanagedType.LPStr)] string log,
    IntPtr user_data);

public static partial class TIMNative
{
    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetMsgExtensionsChangedCallback(TIMMsgCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetMsgExtensionsDeletedCallback(TIMMsgCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetMsgReactionsChangedCallback(TIMMsgCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetMsgAllMessageReceiveOptionCallback(TIMMsgCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetConvTotalUnreadMessageCountChangedCallback(TIMConvCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetConvUnreadMessageCountChangedByFilterCallback(TIMConvCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetConvConversationGroupCreatedCallback(TIMConvCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetConvConversationGroupDeletedCallback(TIMConvCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetConvConversationGroupNameChangedCallback(TIMConvCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetConvConversationsAddedToGroupCallback(TIMConvCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetConvConversationsDeletedFromGroupCallback(TIMConvCallback callback, IntPtr user_data);
}

/// <summary>
/// 会话回调委托
/// </summary>
[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
public delegate void TIMConvCallback([MarshalAs(UnmanagedType.LPStr)] string json_data, IntPtr user_data);

public static partial class TIMNative
{
    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetGroupCounterChangedCallback(TIMGroupCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetGroupTopicCreatedCallback(TIMGroupCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetGroupTopicDeletedCallback(TIMGroupCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetGroupTopicChangedCallback(TIMGroupCallback callback, IntPtr user_data);
}

/// <summary>
/// 群组回调委托
/// </summary>
[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
public delegate void TIMGroupCallback([MarshalAs(UnmanagedType.LPStr)] string json_data, IntPtr user_data);

public static partial class TIMNative
{
    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetCommunityCreateTopicCallback(TIMCommunityCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetCommunityDeleteTopicCallback(TIMCommunityCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetCommunityChangeTopicInfoCallback(TIMCommunityCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetCommunityReceiveTopicRESTCustomDataCallback(TIMCommunityCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetCommunityCreatePermissionGroupCallback(TIMCommunityCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetCommunityDeletePermissionGroupCallback(TIMCommunityCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetCommunityChangePermissionGroupInfoCallback(TIMCommunityCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetCommunityAddMembersToPermissionGroupCallback(TIMCommunityCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetCommunityRemoveMembersFromPermissionGroupCallback(TIMCommunityCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetCommunityAddTopicPermissionCallback(TIMCommunityCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetCommunityDeleteTopicPermissionCallback(TIMCommunityCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetCommunityModifyTopicPermissionCallback(TIMCommunityCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetOnAddFriendCallback(TIMFriendCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetOnDeleteFriendCallback(TIMFriendCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetUpdateFriendProfileCallback(TIMFriendCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetFriendAddRequestCallback(TIMFriendCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetFriendApplicationListDeletedCallback(TIMFriendCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetFriendApplicationListReadCallback(TIMFriendCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetFriendBlackListAddedCallback(TIMFriendCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetFriendBlackListDeletedCallback(TIMFriendCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetFriendGroupCreatedCallback(TIMFriendCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetFriendGroupDeletedCallback(TIMFriendCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetFriendGroupNameChangedCallback(TIMFriendCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetFriendsAddedToGroupCallback(TIMFriendCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetFriendsDeletedFromGroupCallback(TIMFriendCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetSelfInfoUpdatedCallback(TIMUserCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetUserInfoChangedCallback(TIMUserCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetUserStatusChangedCallback(TIMUserCallback callback, IntPtr user_data);
}

/// <summary>
/// 用户回调委托
/// </summary>
[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
public delegate void TIMUserCallback([MarshalAs(UnmanagedType.LPStr)] string json_data, IntPtr user_data);

public static partial class TIMNative
{
    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetNetworkStatusListenerCallback(TIMNetworkStatusCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetKickedOfflineCallback(TIMKickedOfflineCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetUserSigExpiredCallback(TIMUserSigExpiredCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetLogCallback(TIMLogCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetSignalingReceiveNewInvitationCallback(TIMSignalingCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetSignalingInviteeAcceptedCallback(TIMSignalingCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetSignalingInviteeRejectedCallback(TIMSignalingCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetSignalingInvitationCancelledCallback(TIMSignalingCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetSignalingInvitationTimeoutCallback(TIMSignalingCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetSignalingInvitationModifiedCallback(TIMSignalingCallback callback, IntPtr user_data);
}

/// <summary>
/// 信令回调委托
/// </summary>
[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
public delegate void TIMSignalingCallback([MarshalAs(UnmanagedType.LPStr)] string json_data, IntPtr user_data);

public static partial class TIMNative
{
    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetOfficialAccountSubscribedCallback(TIMOfficialAccountCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetOfficialAccountUnsubscribedCallback(TIMOfficialAccountCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetOfficialAccountDeletedCallback(TIMOfficialAccountCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetOfficialAccountInfoChangedCallback(TIMOfficialAccountCallback callback, IntPtr user_data);
}

/// <summary>
/// 公众号回调委托
/// </summary>
[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
public delegate void TIMOfficialAccountCallback([MarshalAs(UnmanagedType.LPStr)] string json_data, IntPtr user_data);

public static partial class TIMNative
{
    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetMyFollowingListChangedCallback(TIMFollowCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetMyFollowersListChangedCallback(TIMFollowCallback callback, IntPtr user_data);

    [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void TIMSetMutualFollowersListChangedCallback(TIMFollowCallback callback, IntPtr user_data);
}

/// <summary>
/// 关注粉丝回调委托
/// </summary>
[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
public delegate void TIMFollowCallback([MarshalAs(UnmanagedType.LPStr)] string json_data, IntPtr user_data);

/// <summary>
/// 好友回调委托
/// </summary>
[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
public delegate void TIMFriendCallback([MarshalAs(UnmanagedType.LPStr)] string json_data, IntPtr user_data);

/// <summary>
/// 社群回调委托
/// </summary>
[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
public delegate void TIMCommunityCallback([MarshalAs(UnmanagedType.LPStr)] string json_data, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
public delegate void TIMMsgRevokeCallback(
    [MarshalAs(UnmanagedType.LPStr)] string json_msg_locator_array,
    IntPtr user_data);

/// <summary>
/// 群提示事件回调委托
/// </summary>
[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
public delegate void TIMGroupTipsEventCallback(
    [MarshalAs(UnmanagedType.LPStr)] string json_group_tip_array,
    IntPtr user_data);

/// <summary>
/// 会话事件回调委托
/// </summary>
[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
public delegate void TIMConvEventCallback(
    int conv_event,
    [MarshalAs(UnmanagedType.LPStr)] string json_conv_array,
    IntPtr user_data);

/// <summary>
/// 消息更新回调委托
/// </summary>
[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
public delegate void TIMMsgUpdateCallback(
    [MarshalAs(UnmanagedType.LPStr)] string json_msg_array,
    IntPtr user_data);

/// <summary>
/// 群属性变更回调委托
/// </summary>
[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
public delegate void TIMGroupAttributeChangedCallback(
    [MarshalAs(UnmanagedType.LPStr)] string group_id,
    [MarshalAs(UnmanagedType.LPStr)] string json_group_attributes,
    IntPtr user_data);

