# VB.NET CRM with SQLite and MaterialSkin.2 (WORK IN PROGRESS)

This project is a Customer Relationship Management (CRM) application built using VB.NET, utilizing SQLite as the local database and MaterialSkin.2 for enhanced UI components.


<!-- Outdated images
## Themes (which save to the database to persist your chosen theme)
### Dark Mode - Purple:
| Main form | Create/edit form | About form |
|--------------------|--------------------|--------------------|
| ![image1](https://github.com/CCianfloneDev/VBCrm/assets/24930067/4304db86-e05a-4724-b31b-036b6043d19f) | ![image2](https://github.com/CCianfloneDev/VBCrm/assets/24930067/f0dae951-41f1-4f83-9bf6-fb37024da326) | ![image](https://github.com/CCianfloneDev/VBCrm/assets/24930067/48a8b5dd-1ddc-439a-9dbc-a3a841dffb15) |

### Dark Mode - Green:

| Main form | Create/edit form | About form |
|--------------------|--------------------|--------------------|
| ![image](https://github.com/CCianfloneDev/VBCrm/assets/24930067/1a82b2fa-ec83-4915-95fd-b3146cb6b996)| ![image](https://github.com/CCianfloneDev/VBCrm/assets/24930067/61d86038-8948-4317-8701-f5dd15f368eb) | ![image](https://github.com/CCianfloneDev/VBCrm/assets/24930067/64afe2f0-74b9-4ae3-b70c-01748e1ffe5f) |

### Light Mode - Blue:
| Main form | Create/edit form | About form |
|--------------------|--------------------|--------------------|
| ![image](https://github.com/CCianfloneDev/VBCrm/assets/24930067/79852e53-ec61-4f9f-884d-e22fef894774)| ![image](https://github.com/CCianfloneDev/VBCrm/assets/24930067/1b621844-cfb0-4b74-9e08-5b51bec9ed2f) | ![image](https://github.com/CCianfloneDev/VBCrm/assets/24930067/54bfffce-caff-4b57-8c0e-a5768fa5ceb0) |


### Light Mode - Green:
| Main form | Create/edit form | About form |
|--------------------|--------------------|--------------------|
| ![image](https://github.com/CCianfloneDev/VBCrm/assets/24930067/1c9544b5-2552-4fbc-b81b-9ba556044b76)| ![image](https://github.com/CCianfloneDev/VBCrm/assets/24930067/45fcd7e7-62d5-4995-8d20-99ad28111c75) | ![image](https://github.com/CCianfloneDev/VBCrm/assets/24930067/db26ce71-8bc5-45b7-9793-5418e00d6682) |
-->
## Features

- **SQLite Database:** Local database setup using SQLite for storing and managing data. So there is no need to connect or setup your own database, the inital launch of the application will handle all of that.
- **MaterialSkin.2 UI:** Enhanced user interface powered by MaterialSkin.2 controls for a modern look and feel.
- **Customization:** Light mode and dark mode with numerous theme options available to the user. You can also edit the column order of the grid and the visibility of columns via a menu item, as well as hide/show any or all search criteria as you wish. All changes are saved to the database and applied on launch.
- **Data management:** Allows users to export and import data via .CSV files, as well as purging all contents.
- **Record management:** CRUD (Create, Read, Update, Delete) operations for managing records.

## Prerequisites

- Visual Studio with VB.NET support.
- MaterialSkin.2 library for WinForms (Add via NuGet).
- SQLite for .NET (System.Data.SQLite) (Add via NuGet).

## Setup Instructions (For Development)

1. **Clone the Repository:**
   Clone this repository to your local machine.

2. **Open in Visual Studio:**
   Open the project in Visual Studio.

3. **Install Dependencies:**
   Use NuGet Package Manager to install MaterialSkin.2 and SQLite for .NET.

4. **Build and Run:**
   Build the solution and run the project in Visual Studio.

## Using the Application

- Launch the application.
- Use the MaterialSkin-enhanced interface to manage contact data.
- Perform CRUD operations for adding, viewing, editing, and deleting contact records.

## Download and Run the Application

1. **Download the Installer:**
   - Go to the [Releases](https://github.com/CCianfloneDev/VBCrm/releases)  section.
   - Download the latest `.msi` installer.

2. **Run the Installer:**
   - Double-click the downloaded `.msi` file.
   - Follow the on-screen instructions to install the application.

3. **Start Using the Application:**
   - Once installed, locate the application in your installed programs.
   - Launch the application to start managing customer data.
  
## 📣 Note:
**Windows Defender SmartScreen:** As I've gone for a free-spirited approach without a paid code signing certificate, you might see a Windows Defender SmartScreen note during installation. No worries, it's just a heads-up

1. **Click "More Info"**
<img src="https://github.com/CCianfloneDev/VBCrm/assets/24930067/fa3ffaf4-676f-458b-b02d-91b04c0bea3c" width="300">

2. **Click "Run anyway."**
<img src="https://github.com/CCianfloneDev/VBCrm/assets/24930067/3dc09b7d-571d-434c-9421-f3b26bca2d5b" width="300">

## Contributing

Contributions are welcome! If you have any suggestions, bug reports, or feature requests, feel free to open an issue or submit a pull request.
