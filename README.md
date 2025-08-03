# 📦 InventoryHub

A modular inventory management system built with **Blazor WebAssembly**, **EF Core**, and **ASP.NET Core Minimal APIs**, fully architected by **Sami Ur Rehman**. Designed to model real-world separation of concerns with a clean DTO pipeline, reusable components, and a decoupled server-client solution.

---

## 🧠 Project Overview

InventoryHub is more than just a CRUD app — it’s an exercise in high-clarity software architecture. From project scaffolding to UI polish, every decision reflects thoughtful planning, rationale-first development, and intuitive data flow.

- **Blazor WebAssembly Frontend**: Bootstrap-styled components, modular pages, DTO-bound forms
- **Minimal API Backend**: Lightweight, fast, and highly testable
- **EF Core Host Project**: Dedicated for DB context, migrations, and schema evolution
- **Shared DTO Library**: Promotes clean client-server communication
- **SQL Server Integration**: Real migrations, relationships, and queryable datasets

---

## ⚙️ Tech Stack

| Layer              | Technology                                 |
|-------------------|---------------------------------------------|
| Frontend          | Blazor WebAssembly + Bootstrap UI           |
| Backend           | ASP.NET Core (.NET 8) Minimal APIs          |
| Data Persistence  | EF Core + SQL Server                        |
| Architecture      | Clean separation via DTOs + dedicated host |
| Styling           | Custom Blazor components w/ real-world UX  |

---

## 🗂️ Folder Structure

```
InventoryHub/
├── ClientApp/                     → Blazor WebAssembly frontend
│   ├── wwwroot/                   → Static assets
│   ├── Layout/                    → Main UI layout components
│   ├── Pages/                     → Product CRUD and navigation pages
│   ├── Services/                  → API communication layer
│   ├── _Imports.razor            → Razor imports
│   ├── App.razor                 → App shell
│   └── Program.cs                → Entry point for Blazor WebAssembly
├── EfHost/                        → EF Core migrations and DB context
│   ├── Data/                      → InventoryDbContext and config
│   ├── Migrations/               → EF migration snapshots
│   ├── Models/                   → DB entity definitions
│   └── Class1.cs                 → Default starter file
├── InventoryHub.Shared/          → Shared DTOs and validation
│   ├── DTOs/                     → ProductDto and others
│   └── Class1.cs                 → Default starter file
├── ServerApp/                    → ASP.NET Core Minimal API backend
│   ├── Controllers/              → API endpoints (e.g., ProductsController)
│   ├── ServerApp/                → Internal services and logic
│   ├── appsettings.json          → App configuration
│   └── Program.cs                → Entry point for Minimal API
```

---

## 🚀 Features

- 🔄 Full Product CRUD (Create, Read, Update, Delete)
- 🎯 DTO-driven communication between Client and Server
- 🧱 Modular Blazor components for reusable layouts and forms
- 🧪 Snapshot-validated EF Core migrations
- 🔒 Clean separation of concerns using project references
- 📈 Architectural decisions documented and milestone-tagged

---

## 💡 Architectural Milestones

| Milestone                         | Description                                                                 |
|----------------------------------|-----------------------------------------------------------------------------|
| ✅ Project Refactor               | Introduced Shared DTO library, decoupling frontend/backend                 |
| ✅ DTO Alignment                  | Rewired services/controllers to use `ProductDto` for clean binding         |
| ✅ Migration Mastery              | Aligned snapshots, resolved namespace errors, and validated metadata       |
| ✅ UI Polish                      | Styled form layout using Bootstrap components and reusable input blocks    |
| ✅ GitHub Integration             | Set up Visual Studio Git flow with `.gitignore`, commits, and README       |

---

## 📖 Usage

1. **Run SQL Server locally**
2. **Apply EF Core migrations via EfHost**
3. **Launch ServerApp** (Minimal APIs on ASP.NET Core)
4. **Run ClientApp** (Blazor UI with full CRUD capability)

---

## 👨‍💻 Author

Crafted with precision and passion by **Sami Ur Rehman**  
📍 Sindh, Pakistan  
🔗 [GitHub Profile](https://github.com/SamiUrRehman065)

---

## 📄 License

Open-source for learning, portfolio enhancement, and architecture inspiration.

---

## 🔁 Commit Convention

Use milestone-driven commit messages like:

```
Add ProductDto and bind to ProductForm
Refactor ProductService for DTO consistency
Fix migration namespace errors and validate snapshots
Style ProductForm with Bootstrap input groups
Integrate server-client via Shared project reference
```
