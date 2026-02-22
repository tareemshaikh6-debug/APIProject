API Project – Employee Management System

📌 Overview

This project is a RESTful Web API built using ASP.NET Core and SQL Server to manage employee data.
It provides full CRUD (Create, Read, Update, Delete) functionality and demonstrates backend development concepts such as database connectivity, API routing, and data handling.

---

🚀 Features

- Create new employee records
- Retrieve all employees or single employee by ID
- Update existing employee details
- Delete employee records
- SQL Server database integration
- REST API using HTTP methods (GET, POST, PUT, DELETE)
- Clean layered structure for scalability

---

🛠️ Technologies Used

- ASP.NET Core Web API
- C#
- SQL Server
- ADO.NET / Entity Framework (as used in project)
- Visual Studio
- Postman (for API testing)

---

📂 Project Structure

APIProject/
│-- Controllers/
│-- Models/
│-- Data/
│-- appsettings.json
│-- Program.cs

---

⚙️ How to Run This Project

1️⃣ Clone the Repository

git clone https://github.com/yourusername/APIProject.git

2️⃣ Open in Visual Studio

Open the ".sln" file in Visual Studio.

3️⃣ Configure Database

Update the connection string in:

appsettings.json

Example:

"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=CompanyDB;Trusted_Connection=True;"
}

4️⃣ Run the Application

Press:

Ctrl + F5

API will start on:

https://localhost:xxxx/swagger

---

🔍 API Endpoints Example

Method| Endpoint| Description
GET| /api/employee| Get all employees
GET| /api/employee/{id}| Get employee by ID
POST| /api/employee| Add new employee
PUT| /api/employee/{id}| Update employee
DELETE| /api/employee/{id}| Delete employee

---

📚 Learning Outcomes

Through this project I learned:

- Building REST APIs using ASP.NET Core
- Connecting .NET applications with SQL Server
- Implementing CRUD operations
- Writing structured backend code
- Testing APIs using Postman
- Using Git for version control

---

👨‍💻 Author

Tareem Shaikh
Aspiring .NET Developer | Backend Enthusiast
