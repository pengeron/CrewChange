# CrewChange

CrewChange is a .NET Core Web API project built using Clean/Onion Architecture, designed to manage employee data and certifications with SQL Server storage and Azure Blob Storage integration.

## Architecture

The solution follows Clean Architecture (Onion Architecture) principles with four main projects:

1. **CrewChange.Domain**
   - Contains enterprise/business logic
   - Entities and domain models
   - No dependencies on other projects or external libraries

2. **CrewChange.Application**
   - Contains business logic and interfaces
   - DTOs and validation
   - Depends only on Domain layer

3. **CrewChange.Infrastructure**
   - Contains implementation details
   - Database context and migrations
   - Repository implementations
   - Azure Blob Storage service
   - Depends on Application layer

4. **CrewChange.API**
   - Web API controllers and configuration
   - Swagger documentation
   - Depends on Infrastructure and Application layers

## Features

- Complete CRUD operations for Employee management
- Employee certification management with document storage
- Reference data management (States, Job Types, etc.)
- Azure Blob Storage integration for document storage
- Swagger API documentation
- Input validation
- AutoMapper for DTO mapping

## Technologies

- .NET Core 6.0+
- Entity Framework Core
- SQL Server
- Azure Blob Storage
- AutoMapper
- Swagger/OpenAPI
- Clean Architecture

## Getting Started

### Prerequisites

- .NET 6.0 SDK or later
- SQL Server
- Azure Storage Account (for blob storage)
- Visual Studio 2022 or VS Code

### Configuration

1. Update the connection string in `appsettings.json`:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Your_SQL_Server_Connection_String"
     },
     "AzureStorageConfig": {
       "ConnectionString": "Your_Azure_Storage_Connection_String",
       "ContainerName": "employee-documents"
     }
   }
   ```

2. Run database migrations:
   ```bash
   cd CrewChange.Infrastructure
   dotnet ef database update --startup-project ../CrewChange.API
   ```

### Running the Application

1. Clone the repository:
   ```bash
   git clone https://github.com/pengeron/CrewChange.git
   ```

2. Navigate to the API project:
   ```bash
   cd CrewChange/CrewChange.API
   ```

3. Run the application:
   ```bash
   dotnet run
   ```

4. Access Swagger UI at `https://localhost:7001/swagger`

## Project Structure

### Domain Layer
- **Entities**
  - Employee
  - EmployeeCertification
  - Reference entities (State, MaritalStatus, etc.)

### Application Layer
- **DTOs**
  - EmployeeDto
  - EmployeeCertificationDto
  - Reference DTOs
- **Interfaces**
  - IEmployeeRepository
  - IEmployeeCertificationRepository
  - IBlobStorageService
- **Validation**
  - Custom validation attributes

### Infrastructure Layer
- **Data**
  - ApplicationDbContext
  - Entity configurations
  - Migrations
- **Repositories**
  - EmployeeRepository
  - EmployeeCertificationRepository
- **Services**
  - BlobStorageService

### API Layer
- **Controllers**
  - EmployeesController
  - EmployeeCertificationsController
  - Reference data controllers

## Development Workflow

1. Create feature branch from `Dev`
2. Implement changes
3. Create pull request to `Dev`
4. Review and merge
5. Merge `Dev` to `master` for releases

## API Endpoints

### Employees
- GET `/api/employees` - List all employees
- GET `/api/employees/{id}` - Get employee by ID
- POST `/api/employees` - Create new employee
- PUT `/api/employees/{id}` - Update employee
- DELETE `/api/employees/{id}` - Delete employee

### Employee Certifications
- GET `/api/employees/{employeeId}/certifications` - List employee certifications
- POST `/api/employees/{employeeId}/certifications` - Add certification
- PUT `/api/employees/{employeeId}/certifications/{id}` - Update certification
- DELETE `/api/employees/{employeeId}/certifications/{id}` - Delete certification

### Reference Data
- GET `/api/states` - List states
- GET `/api/maritalstatuses` - List marital statuses
- GET `/api/educationlevels` - List education levels
(And similar endpoints for other reference data)

## Contributing

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License.
