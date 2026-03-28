# 腾讯云IM C# SDK封装

腾讯云即时通讯IM的C# .NET封装库，基于官方C SDK通过P/Invoke实现。

## 项目结构

```
TencentIM.Native/
├── 封装库/          # C# SDK封装源代码
└── 消息测试程序/    # Avalonia UI测试工具
```

## 快速开始

### 1. 引用封装库

**方式一：添加项目引用**
```xml
<ItemGroup>
  <ProjectReference Include="..\TencentIM.Native\封装库\TencentIM.Native.csproj" />
</ItemGroup>
```

**方式二：复制源代码**
将 `封装库/` 目录复制到你的解决方案中，然后添加项目引用。

### 2. 准备 ImSDK.dll

从腾讯云官方下载C SDK：
- GitHub: https://github.com/tencentyun/TIMSDK/tree/master/cross-platform/Windows
- 将 `ImSDK.dll` 复制到你的项目输出目录（bin/Debug 或 bin/Release）

### 3. 获取配置信息

登录腾讯云控制台 (https://console.cloud.tencent.com/im)：
- 获取 `SdkAppId`
- 获取 `SecretKey`（应用配置 → 开发配置）

### 4. 基本使用

```csharp
using TencentIM.Native;
using TencentIM.Native.Models;

// 初始化
var client = new TencentIMClient(sdkAppId);
client.TIMInit();

// 生成UserSig
var sigGenerator = new UserSigGenerator(sdkAppId, secretKey);
var userSig = sigGenerator.Generate(userId);

// 登录
await client.TIMLogin(userId, userSig);

// 发送消息
var msgJson = JsonSerializer.Serialize(new {
    message_elem_array = new[] {
        new { elem_type = 0, text_elem_content = "Hello!" }
    }
});
await client.TIMMsgSendMessage(targetUserId, TIMConvType.C2C, msgJson);

// 接收消息
client.OnMessageReceived += (s, e) => {
    Console.WriteLine($"收到消息: {e.Content}");
};
```

## 测试工具

运行 `消息测试程序/` 中的Avalonia UI测试工具：

```bash
cd 消息测试程序
dotnet run
```

测试工具提供：
- SDK初始化测试
- 用户登录测试
- 消息收发测试
- 实时日志显示

## API覆盖

已完整封装腾讯云IM C SDK的238个API和69个回调，详见 `封装库/API完整对照表v2.md`

## 技术说明

- 目标框架：.NET 8.0 / .NET 9.0
- 使用P/Invoke调用C SDK
- 支持Windows x64平台
- 异步Task模式封装

## 故障排查

- **DllNotFoundException**: 确保 ImSDK.dll 在程序输出目录
- **登录失败**: 检查 SdkAppId 和 UserSig 是否正确
- **多客户端**: SDK为单例设计，需运行多个进程实例

## 许可证

MIT License
