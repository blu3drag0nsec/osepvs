$Filename = (Get-Location).Path + "\RunasCs.exe"
$base64string_x64 = [Convert]::ToBase64String([IO.File]::ReadAllBytes($FileName))
$base64string_x64 | Out-File RunasCs.base64
