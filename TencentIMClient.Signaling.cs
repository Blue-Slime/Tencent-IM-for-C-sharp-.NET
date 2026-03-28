using TencentIM.Native.Interop;

namespace TencentIM.Native;

/// <summary>
/// 信令功能扩展
/// </summary>
public partial class TencentIMClient
{
    public async Task<bool> TIMSignalingInvite(string jsonInviteParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMSignalingInvite(jsonInviteParam, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMSignalingInviteInGroup(string jsonInviteInGroupParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMSignalingInviteInGroup(jsonInviteInGroupParam, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMSignalingCancel(string jsonCancelParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMSignalingCancel(jsonCancelParam, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMSignalingAccept(string jsonAcceptParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMSignalingAccept(jsonAcceptParam, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMSignalingReject(string jsonRejectParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMSignalingReject(jsonRejectParam, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMSignalingGetSignalingInfo(string jsonMsgParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMSignalingGetSignalingInfo(jsonMsgParam, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMSignalingAddInvitedSignaling(string jsonSignalingInfo) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMSignalingAddInvitedSignaling(jsonSignalingInfo, IntPtr.Zero, IntPtr.Zero) == 0;
    public async Task<bool> TIMSignalingModifyInvitation(string jsonModifyInvitationParam) => !_isLoggedIn ? throw new InvalidOperationException("Not logged in") : TIMNative.TIMSignalingModifyInvitation(jsonModifyInvitationParam, IntPtr.Zero, IntPtr.Zero) == 0;
}
