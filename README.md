# Waste Management System

This is a waste management system developed using .NET MVC framework on Visual Studio 2022 with .NET 8. It is designed to facilitate efficient management of waste disposal and recycling processes.

## Features

- User authentication and authorization.
- CRUD operations for Recording waste material.


## Installation

1. Clone this repository to your local machine:

```bash
git clone https://github.com/yourusername/waste-management-system.git
```

2. Open the solution file (`WasteManagementSystem.sln`) in Visual Studio 2022.

3. Build the solution to restore dependencies:

```
dotnet build
```

4. Configure the database connection string in `appsettings.json` file.

5. Run the database migrations to create the necessary database schema:

```
dotnet ef database update
```

6. Start the application:

```
dotnet run
```

The application will be hosted on `https://localhost:5001` by default.

## Configuration

- Database connection string: Update the `ConnectionStrings` section in `appsettings.json` with your database connection details.

## Usage

1. Record waste Material.

## Acknowledgements

- [ASP.NET Core](https://dotnet.microsoft.com/apps/aspnet)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- [Bootstrap](https://getbootstrap.com/)
- [Font Awesome](https://fontawesome.com/)
