# WebApi

## Overview

This project is a Web API developed in C#. It follows a structured approach to separate concerns into different layers, making the codebase easier to manage and extend.

## Project Structure

- **Business**: Contains business logic and service classes.
- **Core**: Core utilities and helper functions.
- **DataAccess**: Handles data access logic and repository classes.
- **Entities**: Defines entity classes and data models.
- **WebApi**: Main project containing the API controllers and configuration.

## Requirements

- .NET 8.0
- Entity Framework Core
- Any database supported by EF Core

## Setup

1. Clone the repository.
2. Navigate to the project directory.
3. Run `dotnet restore` to install dependencies.
4. Configure the database connection in `appsettings.json`.
5. Run the migrations to set up the database: `dotnet ef database update`.
6. Start the application: `dotnet run`.

## Usage

The API provides endpoints to perform CRUD operations. Documentation for the endpoints can be accessed at `/swagger`.

## Contributing

1. Fork the repository.
2. Create a feature branch.
3. Commit your changes.
4. Open a pull request.

## License

This project is licensed under the MIT License.

## Contact

For any questions or suggestions, please open an issue on GitHub.

*Note: This project is based on a C# course project by Engin Demiroğ.*
