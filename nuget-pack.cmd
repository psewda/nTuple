@echo off
set v=%1
.\tools\nuget pack .\ntulip.nuspec -OutputDirectory .\bin\Release -Properties "version=%v%;configuration=Release"
