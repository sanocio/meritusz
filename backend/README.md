# Meritusz Backend API

ASP.NET Core Web API for the Meritusz Insurance Brokerage website.

## Prerequisites

- .NET 8.0 SDK or later
- MySQL Server 8.0 or later

## Database Setup

### 1. Install MySQL (if not already installed)

For Ubuntu/Debian:
```bash
sudo apt update
sudo apt install mysql-server
sudo systemctl start mysql
sudo systemctl enable mysql
```

For macOS (using Homebrew):
```bash
brew install mysql
brew services start mysql
```

For Windows:
Download and install from https://dev.mysql.com/downloads/mysql/

### 2. Configure MySQL

Connect to MySQL:
```bash
mysql -u root -p
```

Create database and user:
```sql
CREATE DATABASE meritusz;
CREATE USER 'meritusz_user'@'localhost' IDENTIFIED BY 'your_secure_password';
GRANT ALL PRIVILEGES ON meritusz.* TO 'meritusz_user'@'localhost';
FLUSH PRIVILEGES;
EXIT;
```

### 3. Update Connection String

Edit `appsettings.json` and update the connection string:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=meritusz;User=meritusz_user;Password=your_secure_password;"
}
```

## Running the Application

### 1. Install Dependencies
```bash
dotnet restore
```

### 2. Create Database Migrations
```bash
dotnet ef migrations add InitialCreate
```

### 3. Apply Migrations to Database
```bash
dotnet ef database update
```

### 4. Run the Application
```bash
dotnet run
```

The API will be available at:
- HTTP: http://localhost:5029
- HTTPS: https://localhost:7285
- Swagger UI: http://localhost:5029/swagger or https://localhost:7285/swagger

## API Endpoints

### Services
- `GET /api/services` - Get all services
- `GET /api/services/{id}` - Get service by ID

### Insurance Products
- `GET /api/insuranceproducts` - Get all insurance products
- `GET /api/insuranceproducts/{id}` - Get insurance product by ID
- `GET /api/insuranceproducts/category/{category}` - Get insurance products by category

### Contact
- `GET /api/contact` - Get contact information

### About Us
- `GET /api/aboutus` - Get about us information

## Project Structure

```
backend/
├── Controllers/          # API Controllers
│   ├── ServicesController.cs
│   ├── InsuranceProductsController.cs
│   ├── ContactController.cs
│   └── AboutUsController.cs
├── Data/                # Database Context
│   └── ApplicationDbContext.cs
├── Models/              # Data Models
│   ├── Service.cs
│   ├── InsuranceProduct.cs
│   ├── ContactInfo.cs
│   └── AboutUs.cs
├── Program.cs          # Application entry point
└── appsettings.json    # Configuration
```

## Development

### Entity Framework Core Commands

Create new migration:
```bash
dotnet ef migrations add MigrationName
```

Update database:
```bash
dotnet ef database update
```

Remove last migration:
```bash
dotnet ef migrations remove
```

## CORS Configuration

The API is configured to accept requests from:
- http://localhost:4200 (Angular development server)

To add more origins, edit the CORS policy in `Program.cs`.
