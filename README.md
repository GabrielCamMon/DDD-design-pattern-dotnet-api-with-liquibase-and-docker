# MyProject API

![.NET Core](https://img.shields.io/badge/.NET%20Core-6.0-blue)
![PostgreSQL](https://img.shields.io/badge/PostgreSQL-15+-blue)
![Docker](https://img.shields.io/badge/Docker-20.10+-blue)
![Liquibase](https://img.shields.io/badge/Liquibase-4.0+-blue)

MyProject is a RESTful API developed with .NET Core following the Domain-Driven Design (DDD) pattern. The application uses PostgreSQL as its database and Liquibase for database version control. The project is set up to run in a Docker environment with Docker Compose.

## Project Structure

Solution: MyProject
<pre>
├── docker-compose.yml 
├── Dockerfile
├── liquibase/
│   ├── changelog.xml
│   ├── liquibase.properties
│   └── changesets/initial-schema.xml
└── src/
    ├── MyProject.API/
    │   ├── Controllers/
    │   └── Program.cs
    │   └── appsettings.json
    ├── MyProject.Application/
    │   ├── Interfaces/
    │   └── Services/
    ├── MyProject.Domain/
    │   ├── Entities/
    │   └── Interfaces/
    └── MyProject.Infrastructure/
        ├── Data/
        └── Repositories/

</pre>

## Prerequisites

- Docker and Docker Compose installed
- .NET SDK (if you want to run locally without Docker)

## How to Run

### Using Docker (Recommended)

```bash
# Clone the repository
git clone https://github.com/your-username/MyProject.git

# Navigate to the project directory
cd MyProject

# Build and run the containers
docker compose up --build

Running Locally (Without Docker)
Set up PostgreSQL database

Update connection string in appsettings.json

Run the API:

bash
dotnet run --project src/MyProject.API
```

## Database Configuration

The project uses PostgreSQL with Liquibase for database version control. Connection settings can be found in:

appsettings.json (for local development)

Environment variables (for Docker deployment)

## API Endpoints

### Authentication
POST /api/auth/register - Registers a new user

POST /api/auth/login - Logs in and returns a JWT token

### Products
GET /api/product - Returns all products

POST /api/product - Creates a new product

### Development
To apply new database changes:

Add new changeset files to liquibase/changesets/

Reference them in changelog.xml

The changes will be applied automatically when the container starts

## License
This project is open source and is licensed under the MIT License.


