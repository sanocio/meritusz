# Quick Start Guide

This guide will help you get the Meritusz Insurance Brokerage website up and running quickly.

## Prerequisites

Before starting, ensure you have the following installed:

1. **Node.js 18+** (includes npm)
   - Download from: https://nodejs.org/
   - Verify: `node --version` and `npm --version`

2. **.NET 8.0 SDK**
   - Download from: https://dotnet.microsoft.com/download
   - Verify: `dotnet --version`

3. **MySQL Server 8.0+**
   - Download from: https://dev.mysql.com/downloads/mysql/
   - Or use Docker: `docker run --name mysql -e MYSQL_ROOT_PASSWORD=password -p 3306:3306 -d mysql:8`

## Step-by-Step Setup

### 1. Setup MySQL Database

#### Option A: Using MySQL Command Line

```bash
# Connect to MySQL
mysql -u root -p

# Create database
CREATE DATABASE meritusz;

# Create user (optional, recommended for production)
CREATE USER 'meritusz_user'@'localhost' IDENTIFIED BY 'your_password';
GRANT ALL PRIVILEGES ON meritusz.* TO 'meritusz_user'@'localhost';
FLUSH PRIVILEGES;
EXIT;
```

#### Option B: Using Docker

```bash
# Run MySQL in Docker
docker run --name meritusz-mysql \
  -e MYSQL_ROOT_PASSWORD=password \
  -e MYSQL_DATABASE=meritusz \
  -p 3306:3306 \
  -d mysql:8
```

### 2. Setup Backend (.NET API)

```bash
# Navigate to backend directory
cd backend

# Update connection string in appsettings.json if needed
# Default: "Server=localhost;Database=meritusz;User=root;Password=password;"

# Install EF Core tools (if not already installed)
dotnet tool install --global dotnet-ef

# Create and apply database migrations
dotnet ef migrations add InitialCreate
dotnet ef database update

# Run the backend API
dotnet run
```

The API will start at:
- HTTP: http://localhost:5029
- HTTPS: https://localhost:7285
- Swagger UI: http://localhost:5029/swagger or https://localhost:7285/swagger

### 3. Setup Frontend (Angular)

Open a new terminal window:

```bash
# Navigate to frontend directory
cd frontend

# Install dependencies
npm install

# Start the development server
npm start
```

The Angular app will open automatically at: http://localhost:4200

## Testing the Application

1. Open your browser to http://localhost:4200
2. You should see the Meritusz Insurance Brokerage homepage
3. Navigate through the menu:
   - **Home** - Welcome page with services overview
   - **About Us** - Company information
   - **Services** - List of insurance services
   - **Insurance Products** - Available insurance products
   - **Contact** - Company contact details

## Troubleshooting

### Backend Issues

**Problem**: `Could not connect to MySQL server`
- **Solution**: Ensure MySQL is running and the connection string is correct in `appsettings.json`

**Problem**: `Error running migrations`
- **Solution**: Make sure the database exists and the user has proper permissions

### Frontend Issues

**Problem**: `API calls failing with CORS error`
- **Solution**: Ensure the backend is running and CORS is configured correctly in `Program.cs`

**Problem**: `npm install fails`
- **Solution**: Delete `node_modules` folder and `package-lock.json`, then run `npm install` again

## Production Deployment

### Backend Deployment

```bash
cd backend
dotnet publish -c Release -o ./publish
# Deploy the contents of ./publish folder to your server
```

### Frontend Deployment

```bash
cd frontend
npm run build
# Deploy the contents of dist/frontend folder to your web server
```

### Update Configuration for Production

1. **Backend**: Update `appsettings.json` with production MySQL connection string
2. **Frontend**: Update API URL in `src/app/services/api.ts` to your production API endpoint
3. **Backend**: Update CORS policy in `Program.cs` to allow your production domain

## Next Steps

- Customize the content by updating seed data in `backend/Data/ApplicationDbContext.cs`
- Add more insurance products through the database
- Customize styling in Angular components
- Add authentication/authorization if needed
- Implement contact form with email functionality
- Add more pages as needed

## Support

For issues or questions:
- Check the main [README.md](README.md)
- Review backend documentation: [backend/README.md](backend/README.md)
- Review frontend documentation: [frontend/README.md](frontend/README.md)
