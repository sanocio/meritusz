# Meritusz Insurance Brokerage Website

A full-stack web application for Meritusz Biztosítási Alkusz Kft., an insurance brokerage company based in Hungary.

## Tech Stack

### Frontend
- **Angular 19** - Modern web framework
- **TypeScript** - Type-safe JavaScript
- **CSS3** - Styling with responsive design
- **Font Awesome** - Icon library

### Backend
- **.NET 8.0** - ASP.NET Core Web API
- **Entity Framework Core** - ORM for database operations
- **Pomelo MySQL Provider** - MySQL database connector

### Database
- **MySQL 8.0+** - Relational database

## Project Structure

```
meritusz/
├── frontend/               # Angular application
│   ├── src/
│   │   ├── app/
│   │   │   ├── components/    # UI components
│   │   │   ├── models/        # TypeScript interfaces
│   │   │   ├── services/      # API service
│   │   │   └── ...
│   │   └── ...
│   └── README.md
├── backend/                # .NET Web API
│   ├── Controllers/        # API endpoints
│   ├── Data/              # Database context
│   ├── Models/            # Entity models
│   ├── Program.cs         # Application entry point
│   └── README.md
└── README.md              # This file
```

## Features

- **Home Page**: Welcome section with services overview
- **About Us**: Company history, mission, and values
- **Services**: Detailed list of insurance services offered
- **Insurance Products**: Catalog of available insurance products
- **Contact**: Company contact information
- **Responsive Design**: Works on desktop, tablet, and mobile devices
- **RESTful API**: Clean API architecture with CRUD operations
- **MySQL Database**: Persistent data storage with seed data

## Getting Started

### Prerequisites

- Node.js 18+ and npm
- .NET 8.0 SDK
- MySQL Server 8.0+

### Installation

#### 1. Clone the repository

```bash
git clone https://github.com/sanocio/meritusz.git
cd meritusz
```

#### 2. Setup Backend

```bash
cd backend

# Install dependencies
dotnet restore

# Configure MySQL connection string in appsettings.json
# Edit the connection string with your MySQL credentials

# Create database and run migrations
dotnet ef migrations add InitialCreate
dotnet ef database update

# Run the API
dotnet run
```

The API will be available at `https://localhost:5001`

#### 3. Setup Frontend

```bash
cd frontend

# Install dependencies
npm install

# Run development server
npm start
```

The application will be available at `http://localhost:4200`

## Database Setup

See [backend/README.md](backend/README.md) for detailed MySQL setup instructions.

## API Endpoints

- `GET /api/services` - Get all services
- `GET /api/services/{id}` - Get service by ID
- `GET /api/insuranceproducts` - Get all insurance products
- `GET /api/insuranceproducts/{id}` - Get insurance product by ID
- `GET /api/insuranceproducts/category/{category}` - Get products by category
- `GET /api/contact` - Get contact information
- `GET /api/aboutus` - Get about us information

## Development

### Frontend Development

```bash
cd frontend
npm start          # Start development server
npm run build      # Build for production
npm run test       # Run tests
```

### Backend Development

```bash
cd backend
dotnet run         # Start development server
dotnet build       # Build the project
dotnet test        # Run tests
```

## Production Deployment

### Frontend

```bash
cd frontend
npm run build
# Deploy the contents of dist/frontend to your web server
```

### Backend

```bash
cd backend
dotnet publish -c Release -o ./publish
# Deploy the contents of ./publish to your server
```

## Configuration

### Backend Configuration (appsettings.json)

- `ConnectionStrings:DefaultConnection` - MySQL connection string
- CORS policy configured for Angular frontend

### Frontend Configuration

- API URL is configured in `src/app/services/api.ts`
- Update the `apiUrl` to match your production API endpoint

## License

Copyright © 2026 Meritum Biztosítási Alkusz Kft. All rights reserved.

## Contact

For more information, visit [www.meritumalkusz.hu](https://www.meritumalkusz.hu)