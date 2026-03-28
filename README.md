# TencentIM.Native - 腾讯云IM C SDK 封装

## 快速开始

### 1. 准备 ImSDK.dll
从腾讯云官方下载 C SDK:
- GitHub: https://github.com/tencentyun/TIMSDK/tree/master/cross-platform/Windows
- 或腾讯云控制台下载

将 `ImSDK.dll` 放置到: `native/x64/ImSDK.dll`

### 2. 获取配置信息
登录腾讯云控制台 (https://console.cloud.tencent.com/im):
- 获取 `SdkAppId`
- 获取 `SecretKey` (在应用配置 -> 开发配置中)

### 3. 配置测试项目
编辑 `TencentIM.Native.Test/Program.cs`:
```csharp
const long SDK_APP_ID = 你的SdkAppId;
const string SECRET_KEY = "你的SecretKey";
```

### 4. 运行测试
```bash
cd TencentIM.Native.Test
dotnet run
```

## 核心功能

### 初始化和登录
```csharp
var client = new TencentIMClient(SDK_APP_ID);
client.Initialize();

var sigGenerator = new UserSigGenerator(SDK_APP_ID, SECRET_KEY);
var userSig = sigGenerator.Generate(USER_ID);
await client.LoginAsync(USER_ID, userSig);
```

### 消息功能
```csharp
// 发送群组消息
await client.SendGroupTextMessageAsync(GROUP_ID, "Hello!");

// 发送私聊消息
await client.SendC2CTextMessageAsync(USER_ID, "Hi!");

// 发送图片
await client.SendImageMessageAsync(CONV_ID, TIMConvType.Group, "path/to/image.jpg");

// 发送文件
await client.SendFileMessageAsync(CONV_ID, TIMConvType.C2C, "path/to/file.pdf");

// 接收消息
client.OnMessageReceived += (s, e) => {
    Console.WriteLine($"{e.SenderId}: {e.Content}");
};
```

### 群组管理
```csharp
// 创建群组
await client.CreateGroupAsync("群组名称");

// 加入群组
await client.JoinGroupAsync(GROUP_ID);

// 邀请成员
await client.InviteGroupMemberAsync(GROUP_ID, new[] { "user1", "user2" });

// 删除成员
await client.DeleteGroupMemberAsync(GROUP_ID, new[] { "user1" });

// 退出群组
await client.QuitGroupAsync(GROUP_ID);

// 解散群组
await client.DeleteGroupAsync(GROUP_ID);

// 获取已加入群组列表
await client.GetJoinedGroupListAsync();
```

### 好友管理
```csharp
// 添加好友
await client.AddFriendAsync(USER_ID, "备注名");

// 删除好友
await client.DeleteFriendAsync(USER_ID);

// 获取好友列表
await client.GetFriendListAsync();
```

### 会话管理
```csharp
// 获取会话列表
await client.GetConversationListAsync();

// 删除会话
await client.DeleteConversationAsync(CONV_ID, TIMConvType.C2C);
```

## 故障排查
- **DllNotFoundException**: 检查 ImSDK.dll 是否在正确路径
- **登录失败**: 验证 SdkAppId 和 SecretKey 是否正确
- **加入群组失败**: 确认群组已在控制台创建
