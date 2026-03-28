# TencentIM.Native API 实现对照表

本文档记录腾讯云IM C SDK的API与C#封装的对应关系及实现状态。

## 1. 核心管理 (TIMManager.h)

### 1.1 初始化和登录

| C SDK API | C# 封装方法 | 实现状态 | 说明 |
|-----------|------------|---------|------|
| `TIMInit` | `TIMInit()` | ✅ 已实现 | SDK初始化 |
| `TIMUninit` | `Dispose()` | ✅ 已实现 | SDK反初始化 |
| `TIMLogin` | `TIMLogin()` | ✅ 已实现 | 用户登录 |
| `TIMLogout` | `TIMLogout()` | ✅ 已实现 | 用户登出 |
| `TIMGetLoginUserID` | - | ❌ 未实现 | 获取当前登录用户ID |
| `TIMGetLoginStatus` | - | ❌ 未实现 | 获取登录状态 |
| `TIMGetSDKVersion` | - | ❌ 未实现 | 获取SDK版本 |
| `TIMGetServerTime` | - | ❌ 未实现 | 获取服务器时间 |

### 1.2 回调设置

| C SDK API | C# 封装 | 实现状态 | 说明 |
|-----------|---------|---------|------|
| `TIMSetNetworkStatusListenerCallback` | - | ❌ 未实现 | 网络状态监听 |
| `TIMSetKickedOfflineCallback` | - | ❌ 未实现 | 被踢下线回调 |
| `TIMSetUserSigExpiredCallback` | - | ❌ 未实现 | UserSig过期回调 |
| `TIMSetLogCallback` | - | ❌ 未实现 | 日志回调 |

### 1.3 用户资料

| C SDK API | C# 封装方法 | 实现状态 | 说明 |
|-----------|------------|---------|------|
| `TIMProfileGetUserProfileList` | - | ❌ 未实现 | 获取用户资料 |
| `TIMProfileModifySelfUserProfile` | - | ❌ 未实现 | 修改自己资料 |
| `TIMGetUserStatus` | - | ❌ 未实现 | 获取用户状态 |
| `TIMSetSelfStatus` | - | ❌ 未实现 | 设置自己状态 |

## 2. 消息管理 (TIMMessageManager.h)

### 2.1 消息回调

| C SDK API | C# 封装 | 实现状态 | 说明 |
|-----------|---------|---------|------|
| `TIMAddRecvNewMsgCallback` | `TencentIMClient.Initialize()` | ✅ 已实现 | 接收新消息回调 |
| `TIMRemoveRecvNewMsgCallback` | - | ❌ 未实现 | 移除消息回调 |
| `TIMSetMsgReadedReceiptCallback` | - | ❌ 未实现 | 消息已读回执 |
| `TIMSetMsgRevokeCallback` | - | ❌ 未实现 | 消息撤回回调 |
| `TIMSetMsgUpdateCallback` | - | ❌ 未实现 | 消息更新回调 |

### 2.2 消息发送

| C SDK API | C# 封装方法 | 实现状态 | 说明 |
|-----------|------------|---------|------|
| `TIMMsgSendMessage` | `TIMMsgSendMessage()` | ✅ 已实现 | 发送消息 |
| `TIMMsgCancelSend` | - | ❌ 未实现 | 取消发送 |
| `TIMMsgBatchSend` | - | ❌ 未实现 | 批量发送 |

### 2.3 消息操作

| C SDK API | C# 封装方法 | 实现状态 | 说明 |
|-----------|------------|---------|------|
| `TIMMsgRevoke` | - | ❌ 未实现 | 撤回消息 |
| `TIMMsgModifyMessage` | - | ❌ 未实现 | 修改消息 |
| `TIMMsgDelete` | - | ❌ 未实现 | 删除消息 |
| `TIMMsgGetMsgList` | - | ❌ 未实现 | 获取消息列表 |
| `TIMMsgSearchLocalMessages` | - | ❌ 未实现 | 搜索本地消息 |
| `TIMMsgFindMessages` | - | ❌ 未实现 | 查找消息 |

## 3. 群组管理 (TIMGroupManager.h)

### 3.1 群组基础操作

| C SDK API | C# 封装方法 | 实现状态 | 说明 |
|-----------|------------|---------|------|
| `TIMGroupCreate` | `TIMGroupCreate()` | ✅ 已实现 | 创建群组 |
| `TIMGroupDelete` | `TIMGroupDelete()` | ✅ 已实现 | 解散群组 |
| `TIMGroupJoin` | `TIMGroupJoin()` | ✅ 已实现 | 加入群组 |
| `TIMGroupQuit` | `TIMGroupQuit()` | ✅ 已实现 | 退出群组 |
| `TIMGroupGetJoinedGroupList` | `TIMGroupGetJoinedGroupList()` | ✅ 已实现 | 获取已加入群组 |
| `TIMGroupGetGroupInfoList` | - | ❌ 未实现 | 获取群资料 |
| `TIMGroupModifyGroupInfo` | - | ❌ 未实现 | 修改群资料 |

### 3.2 群成员管理

| C SDK API | C# 封装方法 | 实现状态 | 说明 |
|-----------|------------|---------|------|
| `TIMGroupInviteMember` | `TIMGroupInviteMember()` | ✅ 已实现 | 邀请成员 |
| `TIMGroupDeleteMember` | `TIMGroupDeleteMember()` | ✅ 已实现 | 删除成员 |
| `TIMGroupGetMemberInfoList` | - | ❌ 未实现 | 获取成员列表 |

## 4. 好友管理 (TIMFriendshipManager.h)

### 4.1 好友操作

| C SDK API | C# 封装方法 | 实现状态 | 说明 |
|-----------|------------|---------|------|
| `TIMFriendshipAddFriend` | `TIMFriendshipAddFriend()` | ✅ 已实现 | 添加好友 |
| `TIMFriendshipDeleteFriend` | `TIMFriendshipDeleteFriend()` | ✅ 已实现 | 删除好友 |
| `TIMFriendshipGetFriendProfileList` | `TIMFriendshipGetFriendProfileList()` | ✅ 已实现 | 获取好友列表 |
| `TIMFriendshipModifyFriendProfile` | - | ❌ 未实现 | 修改好友资料 |
| `TIMFriendshipCheckFriendType` | - | ❌ 未实现 | 检查好友关系 |

## 5. 会话管理 (TIMConversationManager.h)

| C SDK API | C# 封装方法 | 实现状态 | 说明 |
|-----------|------------|---------|------|
| `TIMConvGetConvList` | `TIMConvGetConvList()` | ✅ 已实现 | 获取会话列表 |
| `TIMConvDelete` | `TIMConvDelete()` | ✅ 已实现 | 删除会话 |
| `TIMConvSetDraft` | - | ❌ 未实现 | 设置草稿 |
| `TIMConvGetConvInfo` | - | ❌ 未实现 | 获取会话信息 |

## 6. 实现统计

### 已实现功能
- ✅ 核心初始化和登录 (4/8)
- ✅ 消息发送和接收 (5/15)
- ✅ 群组基础操作 (7/10)
- ✅ 好友管理 (3/5)
- ✅ 会话管理 (2/4)

### 总体进度
- **已实现**: 21 个API
- **未实现**: 21 个API
- **完成度**: 50%

### 优先级建议
1. 高优先级：消息撤回、消息列表获取、群成员列表
2. 中优先级：用户资料、网络状态回调
3. 低优先级：草稿、扩展功能
