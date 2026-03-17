# Hostel Management System

Windows Forms hostel management app built with **C#** on **.NET Framework 4.7.2** (Visual Studio solution + project).

## Features (screens/modules)
- Student management (add/update/delete, list)
- Employee management (add/update/delete, payments, working/vacated)
- Rooms
- Meals (new/update, calendar)
- Inventory (new/update items, shopping list)

## Tech stack
- **C# WinForms** (`OutputType=WinExe`)
- **.NET Framework 4.7.2**
- **Visual Studio 2022** (solution format indicates VS 17)

## Getting started

### Prerequisites
- Windows
- Visual Studio 2022 with the **.NET desktop development** workload
- .NET Framework **4.7.2** targeting pack (installed by Visual Studio if needed)

### Run (Visual Studio)
1. Open `Hostel Management System (2).sln`
2. Set the project as Startup Project (if it isn’t already)
3. Build and run:
   - `Build` → `Build Solution`
   - `Debug` → `Start Debugging`

## Notes / dependencies

### Guna UI2 (missing reference by default)
This project references `Guna.UI2.dll` via an **absolute path** (from the original author’s machine), so the build may fail on a new PC until you fix the reference:

- Option A (recommended): add the library via **NuGet** (if available for your setup) and update the reference
- Option B: place the `Guna.UI2.dll` on your machine and update the reference path in `Hostel Management System (2).csproj`

## License
Add a license if you plan to publish publicly.

