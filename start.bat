@echo off
REM Meritusz Application Startup Script for Windows
REM This script starts both the backend API and frontend development server

echo Starting Meritusz Insurance Brokerage Application...
echo.

REM Check if dotnet is installed
where dotnet >nul 2>nul
if %errorlevel% neq 0 (
    echo .NET SDK is required but not installed. Aborting.
    pause
    exit /b 1
)

REM Check if npm is installed
where npm >nul 2>nul
if %errorlevel% neq 0 (
    echo npm is required but not installed. Aborting.
    pause
    exit /b 1
)

echo Prerequisites checked
echo.

REM Start backend
echo Starting .NET Backend API...
cd backend
start "Meritusz Backend" cmd /k "dotnet run"
cd ..

echo Waiting for backend to start...
timeout /t 5 /nobreak >nul

REM Start frontend
echo Starting Angular Frontend...
cd frontend
start "Meritusz Frontend" cmd /k "npm start"
cd ..

echo.
echo Both services are starting!
echo.
echo Backend API: https://localhost:5001
echo Frontend: http://localhost:4200
echo Swagger UI: https://localhost:5001/swagger
echo.
echo Close both command windows to stop the services
echo.

pause
