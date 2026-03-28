# 自动更新API对照表脚本
$ErrorActionPreference = "Stop"
$projectDir = Split-Path -Parent $MyInvocation.MyCommand.Path

# 扫描所有实现的API
$implementedApis = @{}

# 扫描P/Invoke声明文件
Get-ChildItem "$projectDir\Interop\TIMNative*.cs" | ForEach-Object {
    $content = Get-Content $_.FullName -Raw -Encoding UTF8
    [regex]::Matches($content, 'public static extern \w+ (TIM\w+)\(') | ForEach-Object {
        $apiName = $_.Groups[1].Value
        $implementedApis[$apiName] = $true
    }
}

# 扫描C#封装文件
Get-ChildItem "$projectDir\TencentIMClient*.cs" | ForEach-Object {
    $content = Get-Content $_.FullName -Raw -Encoding UTF8
    [regex]::Matches($content, 'public (?:async Task<\w+>|void) (TIM\w+)\(') | ForEach-Object {
        $apiName = $_.Groups[1].Value
        $implementedApis[$apiName] = $true
    }
}

Write-Host "找到 $($implementedApis.Count) 个已实现的API" -ForegroundColor Green

# 读取API对照表
$tableFile = "$projectDir\API完整对照表v2.md"
$lines = Get-Content $tableFile -Encoding UTF8

# 更新表格
$updated = 0
for ($i = 0; $i -lt $lines.Count; $i++) {
    $line = $lines[$i]
    if ($line -match '\| `(TIM\w+)`') {
        $apiName = $matches[1]
        if ($implementedApis.ContainsKey($apiName)) {
            if ($line -match '❌ 未实现') {
                $lines[$i] = $line -replace '\| - \| ❌ 未实现 \|', "| ``$apiName()`` | ✅ 已实现 |"
                $updated++
            }
        }
    }
}

# 写回文件
$lines | Out-File $tableFile -Encoding UTF8
Write-Host "更新完成！共更新 $updated 条记录" -ForegroundColor Cyan
