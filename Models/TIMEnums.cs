namespace TencentIM.Native.Models;

/// <summary>
/// 会话类型
/// </summary>
public enum TIMConvType
{
    /// <summary>无效会话</summary>
    Invalid = 0,
    /// <summary>个人会话</summary>
    C2C = 1,
    /// <summary>群组会话</summary>
    Group = 2,
    /// <summary>系统会话</summary>
    System = 3
}

/// <summary>
/// 消息元素类型
/// </summary>
public enum TIMElemType
{
    /// <summary>文本消息</summary>
    Text = 0,
    /// <summary>图片消息</summary>
    Image = 1,
    /// <summary>声音消息</summary>
    Sound = 2,
    /// <summary>自定义消息</summary>
    Custom = 3,
    /// <summary>文件消息</summary>
    File = 4,
    /// <summary>群组系统消息</summary>
    GroupTips = 5,
    /// <summary>表情消息</summary>
    Face = 6,
    /// <summary>位置消息</summary>
    Location = 7,
    /// <summary>群组系统通知</summary>
    GroupReport = 8,
    /// <summary>视频消息</summary>
    Video = 9
}
