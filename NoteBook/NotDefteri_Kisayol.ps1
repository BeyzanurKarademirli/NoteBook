# Masaüstüne kısayol oluşturma scripti
$exePath = "$PSScriptRoot\NoteBook\bin\Debug\NoteBook.exe"
$desktop = [Environment]::GetFolderPath("Desktop")
$shortcutPath = Join-Path $desktop "Not Defteri.lnk"

$WScriptShell = New-Object -ComObject WScript.Shell
$shortcut = $WScriptShell.CreateShortcut($shortcutPath)
$shortcut.TargetPath = $exePath
$shortcut.WorkingDirectory = Split-Path $exePath
$shortcut.IconLocation = $exePath
$shortcut.Description = "Not Defteri Uygulaması"
$shortcut.Save()

Write-Host "Kısayol oluşturuldu: $shortcutPath" -ForegroundColor Green
Write-Host "Masaüstünden 'Not Defteri' kısayoluna çift tıklayarak çalıştırabilirsiniz!"

