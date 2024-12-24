# ASP.NET Clean Architecture App

This is a sample ASP.NET Clean Architecture application. It demonstrates:
- Domain-driven design principles.
- Separation of concerns.
- Dependency injection.

## Layers
1. **Domain**: Entities and repository interfaces.
2. **Application**: Use cases and service logic.
3. **Infrastructure**: Data access and external integrations.
4. **Presentation (Web API)**: This layer acts as the entry point for the application and provides Web API endpoints to interact with the system.

> **Note**: In this implementation, the presentation layer is represented by the Web API. It serves as the interface between the client and the application's business logic.

## Prerequisites
- .NET 6 SDK
- SQL Server

## Setup
1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/your-repository-name.git
