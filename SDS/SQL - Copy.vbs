Dim defPath 
defPath = Replace(WScript.ScriptFullName, WScript.ScriptName, "") 
Set wshShell = WScript.CreateObject ("WSCript.shell")
Set FS = CreateObject("Scripting.FileSystemObject") 
WScript.Echo defPath
'wshshell.Run "osql -S kbcidb -U kbciuser -P +kbci+ -i " & Chr(34) & defPath & "SD_SPS.sql" & Chr(34), 1, True
FS.DeleteFile  defPath & "SD_SPS.sql"
FS.DeleteFile  defPath & "SQL.vb"
set wshshell = Nothing
Set FS = Nothing


