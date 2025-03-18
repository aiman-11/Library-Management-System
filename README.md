# Library Management System

## Overview
The **Library Management System** is a robust Windows Forms application built with C# and .NET, designed to streamline the management of book collections. It adheres to a 3-layer architecture, ensuring separation of concerns and maintainability. The application integrates seamlessly with SQL Server for reliable data storage and retrieval.

## Project Structure
```
Library Management System/
│-- Library Management System/  # Windows Forms application
│-- Data Access Layer/          # Handles all database operations
│-- Business Logic Layer/       # Business logic for book management
│-- Presentation Layer/         # UI implementation with Windows Forms
│-- .github/                    # GitHub-related files
│-- README.md                   # Project documentation
│-- CONTRIBUTING.md             # Contribution guidelines
```

## Installation
1. **Clone the repository**
   ```sh
   git clone https://github.com/aiman-11/Library-Management-System.git
   cd Library-Management-System
   ```

2. **Restore Dependencies**
    ```sh
    dotnet restore
    ```

2. **Open the solution** (`.sln`) in **Visual Studio**.

3. **Configure the Database:**
   - Create a new SQL Server database.
   - Update the connection string in `Database Layer.MyDB` file.

4. **Build and Run** the project from **Visual Studio**.

## Contributing
Contributions are welcome. Before submitting a pull request, please read the [CONTRIBUTING.md](.github/CONTRIBUTING.md) file for guidelines.

## License
This project is open-source and available under the MIT License.
