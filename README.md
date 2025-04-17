# Animal Biography App

A web application built with ASP.NET Core 9.0 that allows users to manage and view detailed information about various animals.

## Features

- Create, read, update, and delete animal biographies
- Store comprehensive information about animals including:
  - Name
  - Species
  - Habitat
  - Description
  - Diet
  - Conservation Status
  - Image URL
  - Date Added
- Modern and responsive user interface
- Data persistence using SQL Server

## Technical Stack

- **Framework**: ASP.NET Core 9.0
- **Database**: SQL Server with Entity Framework Core
- **ORM**: Entity Framework Core 9.0.3
- **Development Tools**: 
  - Entity Framework Core Tools
  - Visual Studio 2022 (recommended)

## Prerequisites

- .NET 9.0 SDK
- SQL Server
- Visual Studio 2022 (recommended) or Visual Studio Code

## Getting Started

1. Clone the repository
2. Open the solution in Visual Studio
3. Update the connection string in `appsettings.json` to point to your SQL Server instance
4. Run the following commands in Package Manager Console:
   ```
   Update-Database
   ```
5. Build and run the application

## Project Structure

- **Controllers/**: Contains the MVC controllers
- **Models/**: Contains the data models
  - `Animal.cs`: Main model for animal information
  - `ErrorViewModel.cs`: Model for error handling
- **Views/**: Contains the Razor views
- **Data/**: Contains the database context and migrations
- **wwwroot/**: Contains static files (CSS, JavaScript, images)
- **Migrations/**: Contains database migration files

## Data Model

The `Animal` class contains the following properties:

- `Id`: Unique identifier
- `Name`: Animal's name (required, max 100 characters)
- `Species`: Animal's species (required, max 100 characters)
- `Habitat`: Animal's natural habitat (required, max 100 characters)
- `Description`: Detailed description of the animal (required)
- `ImageUrl`: URL to the animal's image (max 200 characters)
- `Diet`: Animal's diet information (required)
- `ConservationStatus`: Current conservation status (required)
- `DateAdded`: Timestamp of when the animal was added to the database

## Contributing

1. Fork the repository
2. Create a feature branch
3. Commit your changes
4. Push to the branch
5. Create a Pull Request

## License

This project is licensed under the MIT License - see the LICENSE file for details. 