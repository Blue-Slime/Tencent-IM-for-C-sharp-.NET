using TencentIM.Native.Interop;

namespace TencentIM.Native;

/// <summary>
/// 完整事件回调扩展
/// </summary>
public partial class TencentIMClient
{
    // 回调委托字段
    private TIMMsgCallback? _msgExtChangedCb, _msgExtDeletedCb, _msgReactionsCb, _msgAllOptCb, _msgReadedCb, _msgUploadCb, _msgModifiedCb;
    private TIMLogCallback? _logCb;
    private TIMConvCallback? _convTotalUnreadCb, _convUnreadFilterCb, _convGroupCreatedCb, _convGroupDeletedCb, _convGroupNameCb, _convAddedToGroupCb, _convDeletedFromGroupCb;
    private TIMGroupCallback? _groupCounterCb, _groupTopicCreatedCb, _groupTopicDeletedCb, _groupTopicChangedCb;
    private TIMCommunityCallback? _commCreateTopicCb, _commDeleteTopicCb, _commChangeTopicCb, _commRESTDataCb, _commCreatePermCb, _commDeletePermCb, _commChangePermCb, _commAddMembersCb, _commRemoveMembersCb, _commAddTopicPermCb, _commDeleteTopicPermCb, _commModifyTopicPermCb;
    private TIMFriendCallback? _friendAddCb, _friendDeleteCb, _friendUpdateCb, _friendRequestCb, _friendAppDeletedCb, _friendAppReadCb, _friendBlackAddCb, _friendBlackDeleteCb, _friendGroupCreatedCb, _friendGroupDeletedCb, _friendGroupNameCb, _friendsAddedToGroupCb, _friendsDeletedFromGroupCb;
    private TIMUserCallback? _selfInfoCb, _userInfoCb, _userStatusCb;
    private TIMNetworkStatusCallback? _networkCb;
    private TIMKickedOfflineCallback? _kickedCb;
    private TIMUserSigExpiredCallback? _sigExpiredCb;
    private TIMSignalingCallback? _sigNewInviteCb, _sigAcceptedCb, _sigRejectedCb, _sigCancelledCb, _sigTimeoutCb, _sigModifiedCb;
    private TIMOfficialAccountCallback? _oaSubscribedCb, _oaUnsubscribedCb, _oaDeletedCb, _oaInfoChangedCb;
    private TIMFollowCallback? _followingCb, _followersCb, _mutualCb;

    // 事件
    public event Action<string>? OnMsgExtensionsChanged, OnMsgExtensionsDeleted, OnMsgReactionsChanged, OnMsgAllReceiveOptionChanged;
    public event Action<string>? OnConvTotalUnreadChanged, OnConvUnreadFilterChanged, OnConvGroupCreated, OnConvGroupDeleted, OnConvGroupNameChanged, OnConvAddedToGroup, OnConvDeletedFromGroup;
    public event Action<string>? OnGroupCounterChanged, OnGroupTopicCreated, OnGroupTopicDeleted, OnGroupTopicChanged;
    public event Action<string>? OnCommunityCreateTopic, OnCommunityDeleteTopic, OnCommunityChangeTopic, OnCommunityRESTData, OnCommunityCreatePerm, OnCommunityDeletePerm, OnCommunityChangePerm, OnCommunityAddMembers, OnCommunityRemoveMembers, OnCommunityAddTopicPerm, OnCommunityDeleteTopicPerm, OnCommunityModifyTopicPerm;
    public event Action<string>? OnFriendAdd, OnFriendDelete, OnFriendUpdate, OnFriendRequest, OnFriendAppDeleted, OnFriendAppRead, OnFriendBlackAdd, OnFriendBlackDelete, OnFriendGroupCreated, OnFriendGroupDeleted, OnFriendGroupNameChanged, OnFriendsAddedToGroup, OnFriendsDeletedFromGroup;
    public event Action<string>? OnSelfInfoUpdated, OnUserInfoChanged, OnUserStatusChanged;
    public event Action<int, int, string>? OnNetworkStatus;
    public event Action? OnKickedOffline, OnUserSigExpired;
    public event Action<string>? OnSignalingNewInvite, OnSignalingAccepted, OnSignalingRejected, OnSignalingCancelled, OnSignalingTimeout, OnSignalingModified;
    public event Action<string>? OnOfficialAccountSubscribed, OnOfficialAccountUnsubscribed, OnOfficialAccountDeleted, OnOfficialAccountInfoChanged;
    public event Action<string>? OnFollowingListChanged, OnFollowersListChanged, OnMutualFollowersListChanged;
    public event Action<int, string>? OnLog;

    // 设置回调方法
    public void TIMSetMsgExtensionsChangedCallback() { _msgExtChangedCb = (j, u) => OnMsgExtensionsChanged?.Invoke(j); TIMNative.TIMSetMsgExtensionsChangedCallback(_msgExtChangedCb, IntPtr.Zero); }
    public void TIMSetMsgExtensionsDeletedCallback() { _msgExtDeletedCb = (j, u) => OnMsgExtensionsDeleted?.Invoke(j); TIMNative.TIMSetMsgExtensionsDeletedCallback(_msgExtDeletedCb, IntPtr.Zero); }
    public void TIMSetMsgReactionsChangedCallback() { _msgReactionsCb = (j, u) => OnMsgReactionsChanged?.Invoke(j); TIMNative.TIMSetMsgReactionsChangedCallback(_msgReactionsCb, IntPtr.Zero); }
    public void TIMSetLogCallback() { _logCb = (level, log, u) => OnLog?.Invoke(level, log); TIMNative.TIMSetLogCallback(_logCb, IntPtr.Zero); }
}
