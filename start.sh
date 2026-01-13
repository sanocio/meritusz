#!/bin/bash

# Meritusz Application Startup Script
# This script starts both the backend API and frontend development server

echo "🚀 Starting Meritusz Insurance Brokerage Application..."
echo ""

# Check if required tools are installed
command -v dotnet >/dev/null 2>&1 || { echo "❌ .NET SDK is required but not installed. Aborting." >&2; exit 1; }
command -v npm >/dev/null 2>&1 || { echo "❌ npm is required but not installed. Aborting." >&2; exit 1; }

echo "✅ Prerequisites checked"
echo ""

# Function to cleanup on exit
cleanup() {
    echo ""
    echo "🛑 Shutting down services..."
    kill $BACKEND_PID 2>/dev/null
    kill $FRONTEND_PID 2>/dev/null
    exit 0
}

trap cleanup SIGINT SIGTERM

# Start backend
echo "📦 Starting .NET Backend API..."
cd backend
dotnet run &
BACKEND_PID=$!
cd ..

echo "⏳ Waiting for backend to start..."
sleep 5

# Start frontend
echo "🎨 Starting Angular Frontend..."
cd frontend
npm start &
FRONTEND_PID=$!
cd ..

echo ""
echo "✅ Both services are starting!"
echo ""
echo "📍 Backend API: https://localhost:5001"
echo "📍 Frontend: http://localhost:4200"
echo "📍 Swagger UI: https://localhost:5001/swagger"
echo ""
echo "Press Ctrl+C to stop all services"
echo ""

# Wait for processes
wait
