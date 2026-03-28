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
client.TIMInit();

var sigGenerator = new UserSigGenerator(SDK_APP_ID, SECRET_KEY);
var userSig = sigGenerator.Generate(USER_ID);
await client.TIMLogin(USER_ID, userSig);
```

### 消息功能
```csharp
// 发送消息（需自行构造JSON）
var msgJson = JsonSerializer.Serialize(new {
    message_elem_array = new[] {
        new { elem_type = 0, text_elem_content = "Hello!" }
    }
});
await client.TIMMsgSendMessage(CONV_ID, TIMConvType.Group, msgJson);

// 接收消息
client.OnMessageReceived += (s, e) => {
    Console.WriteLine($"{e.SenderId}: {e.Content}");
};
```

### 群组管理
```csharp
await client.TIMGroupCreate("群组名称");
await client.TIMGroupJoin(GROUP_ID);
await client.TIMGroupInviteMember(GROUP_ID, new[] { "user1", "user2" });
await client.TIMGroupDeleteMember(GROUP_ID, new[] { "user1" });
await client.TIMGroupQuit(GROUP_ID);
await client.TIMGroupDelete(GROUP_ID);
await client.TIMGroupGetJoinedGroupList();
```

### 好友管理
```csharp
await client.TIMFriendshipAddFriend(USER_ID, "备注名");
await client.TIMFriendshipDeleteFriend(USER_ID);
await client.TIMFriendshipGetFriendProfileList();
```

### 会话管理
```csharp
await client.TIMConvGetConvList();
await client.TIMConvDelete(CONV_ID, TIMConvType.C2C);
```

## 故障排查
- **DllNotFoundException**: 检查 ImSDK.dll 是否在正确路径
- **登录失败**: 验证 SdkAppId 和 SecretKey 是否正确
- **加入群组失败**: 确认群组已在控制台创建
