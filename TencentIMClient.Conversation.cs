using System.Text.Json;
using TencentIM.Native.Interop;
using TencentIM.Native.Models;

namespace TencentIM.Native;

/// <summary>
/// 会话管理扩展
/// </summary>
public partial class TencentIMClient
{
    /// <summary>
    /// 获取会话列表
    /// </summary>
    public async Task<bool> GetConversationListAsync()
    {
        if (!_isLoggedIn)
            throw new InvalidOperationException("Not logged in");

        var ret = TIMNative.TIMConvGetConvList(IntPtr.Zero, IntPtr.Zero);
        return ret == 0;
    }

    /// <summary>
    /// 删除会话
    /// </summary>
    public async Task<bool> DeleteConversationAsync(string convId, TIMConvType convType)
    {
        if (!_isLoggedIn)
            throw new InvalidOperationException("Not logged in");

        var ret = TIMNative.TIMConvDelete(convId, (int)convType, IntPtr.Zero, IntPtr.Zero);
        return ret == 0;
    }
}
