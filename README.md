TADBIR_KISH_VIRA Insurance Web API

This project is an ASP.NET Core Web API application that facilitates the calculation of insurance premiums based on predefined coverage rates. It aims to provide an interface for insurance companies to calculate premiums for different coverage types and capital amounts.

Technologies Used

ASP.NET Core: The project is built using ASP.NET Core, a cross-platform framework for building web applications and APIs.
Entity Framework Core: Entity Framework Core is used for data access and provides a convenient way to interact with the database.
Microsoft SQL Server: SQL Server is the chosen database management system for storing coverage rates and insurance request data.
Dependency Injection: The project follows the Dependency Injection pattern, enhancing modularity and testability.
Swagger: Swagger is used to generate API documentation and provides an interactive UI for testing the API endpoints.

Design Patterns

The project primarily follows the Dependency Injection design pattern. Services and repositories are injected into controllers through their constructors, promoting loose coupling and facilitating unit testing.
Clean Code Practices

Organization and Structure: The project adheres to a well-organized folder structure, separating concerns between controllers, data access, models, repositories, and services.
Descriptive Naming: Meaningful and descriptive names are used for classes, methods, and properties, enhancing code readability.
 Single Responsibility Principle: Each class has a clear and focused responsibility, promoting maintainability.
 Dependency Inversion Principle: The use of constructor injection allows the project to depend on abstractions rather than concrete implementations.
Comments and Documentation: Important methods and classes are documented with XML comments, providing context and usage information for developers.
Input Validation: Input validation is implemented in controller methods to ensure that only valid data is processed.

Instructions

Clone the repository to your local machine.
Open the solution in Visual Studio or your preferred code editor.
Review the appsettings.json file and update the database connection string if necessary.
 Open the Package Manager Console and run the following command to apply migrations:

mathematica

Update-Database

Build and run the application.
Access the Swagger UI by navigating to https://localhost:{port}/swagger/index.html, where {port} is the port number used for the application.
Use the Swagger UI to test the API endpoints for calculating insurance premiums.

Conclusion

The TADBIR_KISH_VIRA Insurance Web API demonstrates the implementation of an insurance premium calculation system using ASP.NET Core.
The project emphasizes clean code practices, follows the Dependency Injection pattern, and leverages technologies such as Entity Framework Core and Swagger for enhanced development and documentation.
