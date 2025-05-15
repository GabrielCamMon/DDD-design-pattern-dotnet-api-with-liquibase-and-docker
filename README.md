MyProject API

Description

MyProject is a RESTful API developed with .NET Core following the Domain-Driven Design (DDD) pattern. The application uses PostgreSQL as its database and Liquibase for database version control. The project is set up to run in a Docker environment with Docker Compose.

Project Structure

Solution: MyProject

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

Prerequisites

Docker and Docker Compose installed

.NET SDK (if you want to run locally without Docker)

How to Run

Clone the repository:

git clone https://github.com/your-username/MyProject.git

Navigate to the project directory:

cd MyProject

Run Docker Compose:

docker compose up --build

Database Configuration

The database used is PostgreSQL, configured with Liquibase for version control.

Connection settings are in appsettings.json.

API Endpoints

Authentication

POST /api/auth/register: Registers a new user.

POST /api/auth/login: Logs in and returns a JWT token.

Products

GET /api/product: Returns all products.

POST /api/product: Creates a new product.

License

This project is open source and is licensed under the MIT License.

