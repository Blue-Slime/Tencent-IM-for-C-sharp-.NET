namespace TencentIM.Native.Utils;

/// <summary>
/// 简单日志
/// </summary>
public static class TIMLogger
{
    public static bool Enabled { get; set; } = true;

    public static void Info(string message)
    {
        if (Enabled)
            Console.WriteLine($"[INFO] {DateTime.Now:HH:mm:ss} {message}");
    }

    public static void Error(string message)
    {
        if (Enabled)
            Console.WriteLine($"[ERROR] {DateTime.Now:HH:mm:ss} {message}");
    }

    public static void Debug(string message)
    {
        if (Enabled)
            Console.WriteLine($"[DEBUG] {DateTime.Now:HH:mm:ss} {message}");
    }
}
