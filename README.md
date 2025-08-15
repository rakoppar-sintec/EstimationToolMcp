# EstimationToolMcp

A .NET 9 solution for user estimation and management.

## Features

- User service interface and implementation
- User retrieval tool
- Configurable via `appsettings.json`

## Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- Visual Studio 2022

### Build and Run

1. Clone the repository.
2. Open the solution in Visual Studio 2022.
3. Restore NuGet packages.
4. Build the solution.
5. Run the project.

### Configuration

Edit `appsettings.json` to adjust service settings.

## Project Structure

- `Model/ServiceConfiguration.cs` – Service configuration model
- `Service/IUserService.cs` – User service interface
- `Service/UserService.cs` – User service implementation
- `Tool/GetUsersTool.cs` – Tool for retrieving users
- `Program.cs` – Application entry point

## License

This project is licensed under the MIT License.
