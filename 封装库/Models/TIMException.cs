namespace TencentIM.Native.Models;

/// <summary>
/// IM错误码
/// </summary>
public enum TIMErrorCode
{
    Success = 0,
    InvalidParam = 6001,
    NetworkError = 6002,
    NotLoggedIn = 6003,
    Timeout = 6004,
    Unknown = 9999
}

/// <summary>
/// IM异常
/// </summary>
public class TIMException : Exception
{
    public TIMErrorCode ErrorCode { get; }

    public TIMException(TIMErrorCode code, string message)
        : base($"[{code}] {message}")
    {
        ErrorCode = code;
    }
}
