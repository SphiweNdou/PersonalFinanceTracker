# Personal Finance Tracker

A full-stack ASP.NET Core application designed to help users manage their personal finances. This project follows enterprise-grade architectural patterns using Entity Framework Core, a service-repository abstraction, and clean controller logic to expose a RESTful API.

## 🚀 Features

- 🔐 **User Authentication & Authorization**
- 💰 **Transaction Tracking** – create, update, and delete income or expense entries
- 🧾 **Account Management** – manage account balances and categories
- 📊 **Scalable Architecture** – clean separation of concerns with `Services`, `Repositories`, and `Controllers`
- 🗃️ **Entity Framework Core** – includes migrations and a code-first approach

## 🧰 Tech Stack

- **Backend:** ASP.NET Core Web API
- **ORM:** Entity Framework Core
- **Authentication:** Token-based (assumed from `AuthController`)
- **Project Structure:** Follows enterprise architecture with DI, layered design, and modular folders

## 📂 Folder Structure

- `Controllers/` – API endpoints
- `Models/` – domain models
- `Data/` – database context
- `Services/` – business logic
- `Repositories/` – data access logic
- `Migrations/` – EF Core migrations

## 🛠️ Getting Started

1. Clone the repository:
    ```bash
    git clone https://github.com/SphiweNdou/PersonalFinanceTracker.git
    ```

2. Navigate to the project folder:
    ```bash
    cd PersonalFinanceTracker/PersonalFinanceTracker
    ```

3. Run the project:
    ```bash
    dotnet run
    ```

4. The API will be available at `https://localhost:5001` or `http://localhost:5000`.

## 📌 Notes

- Update your database connection string in `appsettings.json` before running migrations.
- Swagger or Postman can be used to test API endpoints.

## 🧑‍💻 Author

Sphiwe Ndou – [GitHub](https://github.com/SphiweNdou)

---

