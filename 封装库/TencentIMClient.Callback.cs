using TencentIM.Native.Interop;

namespace TencentIM.Native;

/// <summary>
/// 事件回调扩展
/// </summary>
public partial class TencentIMClient
{
    private TIMMsgRevokeCallback? _msgRevokeCallback;
    private TIMGroupTipsEventCallback? _groupTipsCallback;
    private TIMConvEventCallback? _convEventCallback;
    private TIMMsgUpdateCallback? _msgUpdateCallback;
    private TIMGroupAttributeChangedCallback? _groupAttributeChangedCallback;

    /// <summary>
    /// 消息撤回事件
    /// </summary>
    public event Action<string>? OnMsgRevoke;

    /// <summary>
    /// 群提示事件
    /// </summary>
    public event Action<string>? OnGroupTips;

    /// <summary>
    /// 会话事件
    /// </summary>
    public event Action<int, string>? OnConvEvent;

    /// <summary>
    /// 消息更新事件
    /// </summary>
    public event Action<string>? OnMsgUpdate;

    /// <summary>
    /// 群属性变更事件
    /// </summary>
    public event Action<string, string>? OnGroupAttributeChanged;

    /// <summary>
    /// 设置消息撤回回调 (对应 TIMSetMsgRevokeCallback)
    /// </summary>
    public void TIMSetMsgRevokeCallback()
    {
        _msgRevokeCallback = (json_msg_locator_array, user_data) =>
        {
            OnMsgRevoke?.Invoke(json_msg_locator_array);
        };
        TIMNative.TIMSetMsgRevokeCallback(_msgRevokeCallback, IntPtr.Zero);
    }

    /// <summary>
    /// 设置群提示事件回调 (对应 TIMSetGroupTipsEventCallback)
    /// </summary>
    public void TIMSetGroupTipsEventCallback()
    {
        _groupTipsCallback = (json_group_tip_array, user_data) =>
        {
            OnGroupTips?.Invoke(json_group_tip_array);
        };
        TIMNative.TIMSetGroupTipsEventCallback(_groupTipsCallback, IntPtr.Zero);
    }

    /// <summary>
    /// 设置会话事件回调 (对应 TIMSetConvEventCallback)
    /// </summary>
    public void TIMSetConvEventCallback()
    {
        _convEventCallback = (conv_event, json_conv_array, user_data) =>
        {
            OnConvEvent?.Invoke(conv_event, json_conv_array);
        };
        TIMNative.TIMSetConvEventCallback(_convEventCallback, IntPtr.Zero);
    }

    /// <summary>
    /// 设置消息更新回调 (对应 TIMSetMsgUpdateCallback)
    /// </summary>
    public void TIMSetMsgUpdateCallback()
    {
        _msgUpdateCallback = (json_msg_array, user_data) =>
        {
            OnMsgUpdate?.Invoke(json_msg_array);
        };
        TIMNative.TIMSetMsgUpdateCallback(_msgUpdateCallback, IntPtr.Zero);
    }

    /// <summary>
    /// 设置群属性变更回调 (对应 TIMSetGroupAttributeChangedCallback)
    /// </summary>
    public void TIMSetGroupAttributeChangedCallback()
    {
        _groupAttributeChangedCallback = (group_id, json_group_attributes, user_data) =>
        {
            OnGroupAttributeChanged?.Invoke(group_id, json_group_attributes);
        };
        TIMNative.TIMSetGroupAttributeChangedCallback(_groupAttributeChangedCallback, IntPtr.Zero);
    }
}
