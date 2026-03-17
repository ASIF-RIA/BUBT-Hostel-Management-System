# BUBT Hostel Management System

A Windows desktop application for managing hostel operations (students, employees, rooms, meals, and inventory). Built with **C# WinForms** on **.NET Framework 4.7.2**.

## Key modules
- **Students**: add / update / delete, list
- **Employees**: add / update / delete, payments, working/vacated
- **Rooms**: room management
- **Meals**: meal setup and calendar
- **Inventory**: items, updates, shopping list

## Tech stack
- **C# WinForms** (`OutputType=WinExe`)
- **.NET Framework 4.7.2**
- **Visual Studio 2022** (solution targets VS 17 format)

## Repository contents
- `Hostel Management System (2).sln`: Visual Studio solution
- `Hostel Management System (2).csproj`: project file
- `*.cs`, `*.Designer.cs`, `*.resx`: WinForms source, designer, and resources

## Getting started

### Prerequisites
- Windows 10/11
- Visual Studio 2022 with **.NET desktop development** workload
- **.NET Framework 4.7.2** targeting pack (Visual Studio can install it)

### Run the app (Visual Studio)
1. Open `Hostel Management System (2).sln`
2. Make sure the project is set as the **Startup Project**
3. `Build` → `Build Solution`
4. `Debug` → `Start Debugging` (or press **F5**)

## Configuration

### Database connection
This project uses `System.Data.SqlClient`. Update the SQL Server connection string in `function.cs`:
- `function.getConnection()` → `con.ConnectionString = "..."`;

If you plan to publish this repo publicly, **do not commit real credentials**. Prefer Windows Authentication or environment-specific configuration.

### UI library: Guna UI2
The project currently references `Guna.UI2.dll` via an **absolute path** in the `.csproj`, which may break builds on other machines.

Recommended fixes:
- **Option A (preferred)**: install/reference Guna UI2 in a portable way (e.g., NuGet if available for your setup)
- **Option B**: add the DLL locally and update the reference path in `Hostel Management System (2).csproj`

## Build output
Compiled binaries are produced in:
- `bin/Debug/`
- `bin/Release/`

These folders are intentionally ignored by git.

## Troubleshooting
- **Build fails with missing `Guna.UI2`**: fix the reference as described above.
- **Database errors**: verify SQL Server is running and your connection string is correct.

## Screenshots (optional)
Add screenshots to a `docs/` folder and reference them here, for example:
- `docs/dashboard.png`

## License
No license has been added yet. If you want others to use/modify this project publicly, add a license (e.g., MIT).

