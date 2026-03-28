using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace TencentIM.Native.Utils;

/// <summary>
/// UserSig生成器
/// </summary>
public class UserSigGenerator
{
    private readonly long _sdkAppId;
    private readonly string _secretKey;

    public UserSigGenerator(long sdkAppId, string secretKey)
    {
        _sdkAppId = sdkAppId;
        _secretKey = secretKey;
    }

    public string Generate(string userId, int expireSeconds = 86400 * 180)
    {
        var currTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

        var doc = new Dictionary<string, object>
        {
            ["TLS.ver"] = "2.0",
            ["TLS.identifier"] = userId,
            ["TLS.sdkappid"] = _sdkAppId,
            ["TLS.expire"] = expireSeconds,
            ["TLS.time"] = currTime
        };

        var jsonStr = JsonSerializer.Serialize(doc);
        var sig = HmacSha256(_secretKey, jsonStr);

        var sigDoc = new Dictionary<string, object>
        {
            ["TLS.sig"] = sig,
            ["TLS.ver"] = "2.0",
            ["TLS.identifier"] = userId,
            ["TLS.sdkappid"] = _sdkAppId,
            ["TLS.expire"] = expireSeconds,
            ["TLS.time"] = currTime
        };

        var result = Convert.ToBase64String(Encoding.UTF8.GetBytes(JsonSerializer.Serialize(sigDoc)));
        return result.Replace('+', '*').Replace('/', '-').Replace("=", "_");
    }

    private string HmacSha256(string key, string data)
    {
        using var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(key));
        var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(data));
        return Convert.ToBase64String(hash);
    }
}
