[![Language](https://img.shields.io/badge/Language-C%23-512BD4?style=flat-square&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Framework](https://img.shields.io/badge/Framework-.NET%208-5C2D91?style=flat-square&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
[![Web Framework](https://img.shields.io/badge/Web%20Framework-ASP.NET%20Core-6F2B8F?style=flat-square&logo=aspnet&logoColor=white)](https://docs.microsoft.com/en-us/aspnet/core/)
[![ORM](https://img.shields.io/badge/ORM-Entity%20Framework%20Core-007ACC?style=flat-square&logo=.net&logoColor=white)](https://docs.microsoft.com/en-us/ef/core/)
[![Database](https://img.shields.io/badge/Database-SQL%20Server-CC2927?style=flat-square&logo=microsoft-sql-server&logoColor=white)](https://www.microsoft.com/en-us/sql-server)
[![Frontend](https://img.shields.io/badge/Frontend-Bootstrap%205-7952B3?style=flat-square&logo=bootstrap&logoColor=white)](https://getbootstrap.com/)
[![IDE](https://img.shields.io/badge/IDE-Visual%20Studio%202022-5C2D91?style=flat-square&logo=visual-studio&logoColor=white)](https://visualstudio.microsoft.com/)

# MyProductCatalog - ASP.NET Core MVC Web Application



A modern, responsive, and database-driven web application built with ASP.NET Core MVC and Entity Framework Core. This project serves as a complete, end-to-end example of building a web application from development to deployment.

This application is a simple product catalog management system where users can perform full CRUD (Create, Read, Update, Delete) operations on a list of products. The data is stored in a SQL Server database, and the user interface is styled with a custom Bootstrap 5 theme.

---

## ✨ Features

- **Full CRUD Functionality:** Add, view, edit, and delete products.
- **Modern UI/UX:** A clean, minimal, and visually appealing user interface built with Bootstrap 5, custom CSS, and Bootstrap Icons.
- **Responsive Design:** The layout is fully responsive and works beautifully on desktops, tablets, and mobile devices.
- **Database-Driven:** Uses Entity Framework Core to interact with a SQL Server database.
- **Model-View-Controller (MVC) Pattern:** Follows the standard ASP.NET Core MVC architecture for a clean separation of concerns.
- **Validation:** Implements server-side data validation using Data Annotations.

---

## 🚀 Technologies Used

- **Backend:**
  - [.NET 8](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
  - ASP.NET Core MVC
  - C#
- **Database:**
  - SQL Server
  - Entity Framework Core 8
- **Frontend:**
  - HTML5 & CSS3
  - Bootstrap 5
  - Bootstrap Icons
  - Google Fonts (Poppins)
- **Development Environment:**
  - Visual Studio 2022

---

## 🛠️ Getting Started

Follow these instructions to get a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

You will need the following tools installed on your machine:
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/community/) (Community Edition is free)
  - Make sure to install the **"ASP.NET and web development"** workload.
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [SQL Server Management Studio (SSMS)](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms)

### Installation and Setup

1.  **Clone the repository:**
    ```bash
    git clone https://github.com/your-username/MyProductCatalog.git
    cd MyProductCatalog
    ```

2.  **Open the project in Visual Studio:**
    - Double-click the `MyProductCatalog.sln` file to open the solution in Visual Studio.

3.  **Update the Database Connection String:**
    - Open the `appsettings.json` file.
    - Find the `ConnectionStrings` section.
    - Ensure the `Server` value in the `DefaultConnection` string points to your local SQL Server instance (e.g., `.\\SQLExpress` or `(localdb)\\mssqllocaldb`).
    ```json
    "ConnectionStrings": {
      "DefaultConnection": "Server=.\\SQLExpress;Database=MyProductCatalogDB;Trusted_Connection=True;TrustServerCertificate=True"
    }
    ```

4.  **Create the Database with Migrations:**
    - In Visual Studio, go to **Tools -> NuGet Package Manager -> Package Manager Console**.
    - Run the following command to create the database and its tables based on the code:
    ```powershell
    Update-Database
    ```

5.  **Run the application:**
    - Press `F5` or click the green play button in Visual Studio to build and run the project.
    - Your default web browser will open, and you should see the product catalog homepage.





---

## 👤 Author

- **Harshal Menge** - [Github Link - harryme17](https://github.com/harryme17)
