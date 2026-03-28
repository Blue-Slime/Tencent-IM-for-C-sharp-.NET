# TencentIM.Native 完整API对照表

本文档记录腾讯云IM C SDK的所有API与C#封装的对应关系及实现状态。

## 1. SDK初始化相关接口

| C SDK API | C# 封装方法 | 实现状态 | 说明 |
|-----------|------------|---------|------|
| `TIMInit` | `TIMInit()` | ✅ 已实现 | SDK初始化 |
| `TIMUninit` | `Dispose()` | ✅ 已实现 | SDK卸载 |
| `TIMGetSDKVersion` | `TIMGetSDKVersion()` | ✅ 已实现 | 获取SDK版本号 |
| `TIMGetServerTime` | `TIMGetServerTime()` | ✅ 已实现 | 获取服务器当前时间 |
| `TIMSetConfig` | - | ❌ 未实现 | 设置额外的用户配置 |

## 2. 登录登出相关接口

| C SDK API | C# 封装方法 | 实现状态 | 说明 |
|-----------|------------|---------|------|
| `TIMLogin` | `TIMLogin()` | ✅ 已实现 | 登录 |
| `TIMLogout` | `TIMLogout()` | ✅ 已实现 | 登出 |
| `TIMGetLoginUserID` | `TIMGetLoginUserID()` | ✅ 已实现 | 获取登录用户的userID |
| `TIMGetLoginStatus` | `TIMGetLoginStatus()` | ✅ 已实现 | 获取登录状态 |

## 3. 消息相关接口

### 3.1 消息发送

| C SDK API | C# 封装方法 | 实现状态 | 说明 |
|-----------|------------|---------|------|
| `TIMMsgSendMessage` | `TIMMsgSendMessage()` | ✅ 已实现 | 发送新消息 |
| `TIMMsgCancelSend` | - | ❌ 未实现 | 取消发送中的消息 |
| `TIMMsgBatchSend` | - | ❌ 未实现 | 群发消息 |

### 3.2 消息操作

| C SDK API | C# 封装方法 | 实现状态 | 说明 |
|-----------|------------|---------|------|
| `TIMMsgRevoke` | `TIMMsgRevoke()` | ✅ 已实现 | 消息撤回 |
| `TIMMsgModifyMessage` | - | ❌ 未实现 | 消息修改 |
| `TIMMsgDelete` | `TIMMsgDelete()` | ✅ 已实现 | 删除指定会话的消息 |
| `TIMMsgListDelete` | - | ❌ 未实现 | 删除消息列表 |
| `TIMMsgClearHistoryMessage` | - | ❌ 未实现 | 清空会话消息 |
| `TIMMsgGetMsgList` | `TIMMsgGetMsgList()` | ✅ 已实现 | 获取消息列表 |

### 3.3 消息高级功能

| C SDK API | C# 封装方法 | 实现状态 | 说明 |
|-----------|------------|---------|------|
| `TIMMsgDownloadElemToPath` | - | ❌ 未实现 | 下载消息元素 |
| `TIMMsgSearchLocalMessages` | - | ❌ 未实现 | 搜索本地消息 |
| `TIMMsgSearchCloudMessages` | - | ❌ 未实现 | 搜索云端消息 |
| `TIMMsgFindMessages` | - | ❌ 未实现 | 查找消息 |
| `TIMMsgSetC2CReceiveMessageOpt` | - | ❌ 未实现 | 设置C2C消息接收选项 |
| `TIMMsgSetGroupReceiveMessageOpt` | - | ❌ 未实现 | 设置群消息接收选项 |

## 4. 会话列表相关接口

| C SDK API | C# 封装方法 | 实现状态 | 说明 |
|-----------|------------|---------|------|
| `TIMConvGetConvList` | `TIMConvGetConvList()` | ✅ 已实现 | 获取会话列表 |
| `TIMConvDelete` | `TIMConvDelete()` | ✅ 已实现 | 删除会话 |
| `TIMConvGetConvInfo` | - | ❌ 未实现 | 查询会话列表 |
| `TIMConvSetDraft` | - | ❌ 未实现 | 设置会话草稿 |
| `TIMConvPinConversation` | - | ❌ 未实现 | 设置会话置顶 |

## 5. 群组相关接口

### 5.1 群组基础操作

| C SDK API | C# 封装方法 | 实现状态 | 说明 |
|-----------|------------|---------|------|
| `TIMGroupCreate` | `TIMGroupCreate()` | ✅ 已实现 | 创建群组 |
| `TIMGroupDelete` | `TIMGroupDelete()` | ✅ 已实现 | 删除群组 |
| `TIMGroupJoin` | `TIMGroupJoin()` | ✅ 已实现 | 申请加入群组 |
| `TIMGroupQuit` | `TIMGroupQuit()` | ✅ 已实现 | 退出群组 |
| `TIMGroupGetJoinedGroupList` | `TIMGroupGetJoinedGroupList()` | ✅ 已实现 | 获取已加入群组列表 |
| `TIMGroupGetGroupInfoList` | - | ❌ 未实现 | 获取群组信息列表 |
| `TIMGroupModifyGroupInfo` | - | ❌ 未实现 | 修改群信息 |

### 5.2 群成员管理

| C SDK API | C# 封装方法 | 实现状态 | 说明 |
|-----------|------------|---------|------|
| `TIMGroupInviteMember` | `TIMGroupInviteMember()` | ✅ 已实现 | 邀请加入群组 |
| `TIMGroupDeleteMember` | `TIMGroupDeleteMember()` | ✅ 已实现 | 删除群组成员 |
| `TIMGroupGetMemberInfoList` | - | ❌ 未实现 | 获取群成员信息列表 |

## 6. 好友相关接口

| C SDK API | C# 封装方法 | 实现状态 | 说明 |
|-----------|------------|---------|------|
| `TIMFriendshipAddFriend` | `TIMFriendshipAddFriend()` | ✅ 已实现 | 添加好友 |
| `TIMFriendshipDeleteFriend` | `TIMFriendshipDeleteFriend()` | ✅ 已实现 | 删除好友 |
| `TIMFriendshipGetFriendProfileList` | `TIMFriendshipGetFriendProfileList()` | ✅ 已实现 | 获取好友列表 |
| `TIMFriendshipModifyFriendProfile` | - | ❌ 未实现 | 更新好友资料 |
| `TIMFriendshipGetBlackList` | - | ❌ 未实现 | 获取黑名单列表 |

## 7. 用户资料相关接口

| C SDK API | C# 封装方法 | 实现状态 | 说明 |
|-----------|------------|---------|------|
| `TIMProfileGetUserProfileList` | - | ❌ 未实现 | 获取用户资料 |
| `TIMProfileModifySelfUserProfile` | - | ❌ 未实现 | 修改自己的资料 |
| `TIMGetUserStatus` | - | ❌ 未实现 | 获取用户状态 |
| `TIMSetSelfStatus` | - | ❌ 未实现 | 设置自己的状态 |

## 8. 事件回调接口

| C SDK API | C# 封装方法 | 实现状态 | 说明 |
|-----------|------------|---------|------|
| `TIMAddRecvNewMsgCallback` | `TIMInit()中自动注册` | ✅ 已实现 | 接收新消息回调 |
| `TIMSetNetworkStatusListenerCallback` | - | ❌ 未实现 | 网络状态回调 |
| `TIMSetKickedOfflineCallback` | - | ❌ 未实现 | 被踢下线回调 |

## 9. 实现统计

- **已实现**: 28个API
- **未实现**: 约70+个API
- **完成度**: 约28%

**说明**: 本对照表仅列出常用API，完整API列表包含100+个接口。
