using TencentIM.Native.Interop;
using TencentIM.Native.Models;

namespace TencentIM.Native;

/// <summary>
/// 消息高级功能扩展
/// </summary>
public partial class TencentIMClient
{
    public async Task<bool> TIMMsgSetGroupReceiveMessageOpt(string groupId, int opt) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMMsgSetGroupReceiveMessageOpt(groupId, opt, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMMsgSetAllReceiveMessageOpt(int opt, int startHour, int startMinute, int duration) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMMsgSetAllReceiveMessageOpt(opt, startHour, startMinute, duration, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMMsgSetAllReceiveMessageOpt2(int opt, int startTimeStamp, int duration) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMMsgSetAllReceiveMessageOpt2(opt, startTimeStamp, duration, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMMsgGetAllReceiveMessageOpt() => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMMsgGetAllReceiveMessageOpt(IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMMsgSendMessageReadReceipts(string jsonMsgArray) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMMsgSendMessageReadReceipts(jsonMsgArray, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMMsgGetMessageReadReceipts(string jsonMsgArray) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMMsgGetMessageReadReceipts(jsonMsgArray, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMMsgGetGroupMessageReadMemberList(string jsonMsgParam, int filter, ulong nextSeq, int count) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMMsgGetGroupMessageReadMemberList(jsonMsgParam, filter, nextSeq, count, IntPtr.Zero, IntPtr.Zero) == 0;
}
