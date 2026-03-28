using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TencentIM.Native;
using TencentIM.Native.Models;

namespace ImTestCs.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private TencentIMClient? _client;

    [ObservableProperty]
    private string _sdkAppId = "";

    [ObservableProperty]
    private string _userId = "";

    [ObservableProperty]
    private string _userSig = "";

    [ObservableProperty]
    private string _targetUserId = "";

    [ObservableProperty]
    private string _messageToSend = "";

    [ObservableProperty]
    private string _status = "未初始化";

    [ObservableProperty]
    private bool _isLoggedIn = false;

    public ObservableCollection<string> LogMessages { get; } = new();

    private void AddLog(string message)
    {
        var log = $"[{DateTime.Now:HH:mm:ss}] {message}";
        LogMessages.Insert(0, log);
    }

    [RelayCommand]
    private async Task InitSdk()
    {
        try
        {
            if (!uint.TryParse(SdkAppId, out var appId))
            {
                AddLog("错误: SdkAppId必须是数字");
                return;
            }

            _client = new TencentIMClient(appId);
            _client.TIMInit();
            _client.OnMessageReceived += (s, e) => AddLog($"[收到消息] {e.SenderId}: {e.Content}");

            Status = "已初始化";
            AddLog("SDK初始化成功");
        }
        catch (Exception ex)
        {
            AddLog($"初始化失败: {ex.Message}");
        }
    }

    [RelayCommand]
    private async Task Login()
    {
        try
        {
            if (_client == null) { AddLog("请先初始化SDK"); return; }

            AddLog($"正在登录: {UserId}...");

            _client.OnConnected += (s, e) =>
            {
                IsLoggedIn = true;
                Status = $"已登录: {UserId}";
                AddLog($"✓ 登录成功: {UserId}");
            };

            var result = await _client.TIMLogin(UserId, UserSig);
            if (!result)
            {
                AddLog("✗ 登录失败");
            }
        }
        catch (Exception ex) { AddLog($"登录异常: {ex.Message}"); }
    }

    [RelayCommand]
    private async Task SendMessage()
    {
        try
        {
            if (_client == null || !IsLoggedIn) { AddLog("未登录"); return; }
            if (string.IsNullOrEmpty(MessageToSend)) { AddLog("消息不能为空"); return; }
            if (string.IsNullOrEmpty(TargetUserId)) { AddLog("请输入接收方ID"); return; }

            var msgJson = System.Text.Json.JsonSerializer.Serialize(new
            {
                message_elem_array = new[]
                {
                    new { elem_type = 0, text_elem_content = MessageToSend }
                }
            });

            var result = await _client.TIMMsgSendMessage(TargetUserId, TIMConvType.C2C, msgJson);
            if (result)
                AddLog($"[发送] -> {TargetUserId}: {MessageToSend}");
            else
                AddLog("发送失败");

            MessageToSend = "";
        }
        catch (Exception ex) { AddLog($"发送失败: {ex.Message}"); }
    }
}
