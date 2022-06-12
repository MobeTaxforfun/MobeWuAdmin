rem  .EF core db first 生產方法
@ECHO OFF

FOR /F %%I IN ('dotnet ef --version') DO SET _efversion=%%I
echo %_efversion%

if %_efversion% == "" (
    echo "尚未安裝EF Core"
    exit /b 0
) 

dotnet ef dbcontext scaffold "Data Source=.\sqlexpress;Initial Catalog=MobeAdmin;Integrated Security = true;" Microsoft.EntityFrameworkCore.SqlServer -o Models/MSSQL/Entities -f ^
-t SysMenu

set /p temp="Enter to End" 