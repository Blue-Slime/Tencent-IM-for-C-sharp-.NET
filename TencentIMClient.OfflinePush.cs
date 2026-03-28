namespace TencentIM.Native;

/// <summary>
/// 离线推送相关接口
/// </summary>
public partial class TencentIMClient
{
    public async Task<bool> TIMMsgSetOfflinePushToken(string jsonTokenParam)
        => await Task.Run(() => TIMNative.TIMMsgSetOfflinePushToken(jsonTokenParam, IntPtr.Zero, IntPtr.Zero) == 0);

    public async Task<bool> TIMMsgDoBackground(int unreadCount)
        => await Task.Run(() => TIMNative.TIMMsgDoBackground(unreadCount, IntPtr.Zero, IntPtr.Zero) == 0);

    public async Task<bool> TIMMsgDoForeground()
        => await Task.Run(() => TIMNative.TIMMsgDoForeground(IntPtr.Zero, IntPtr.Zero) == 0);
}
