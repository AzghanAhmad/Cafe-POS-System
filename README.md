# Cafe POS System ☕

**A comprehensive Point-of-Sale (POS) system** for cafe management, built with C# .NET Windows Forms and SQL Server. Supports role-based access for Admin, Employees, and Customers, handling operations like order placement, inventory management, discounts, payments, and feedback.

> **Academic Project** — Submitted to: **Sir Bilal Khalid**  
> **Institution**: FAST – National University of Computer & Emerging Sciences (NUCES), Department of Computing - Software Engineering, Islamabad  
> **Semester**: Spring 2024  
> **Date**: 05/05/24

---

## 👥 Team Members

| Name             | Roll No.   |
|------------------|------------|
| **Azghan Ahmad** | 22I-2667   |
| Faisal           | 22I-8758   |

---

## 🚀 How to Run

This is a Visual Studio C# project. To run:

1. Open the project in Visual Studio (open the .sln file if present, or create one for the .csproj).
2. Attach the SQL Server database `CMS.mdf` (ensure SQL Server is installed and configured).
3. Build the solution (Ctrl + Shift + B).
4. Run the application (F5 or Debug > Start Debugging).

> **Note**: The app uses forms for Admin, Customer, and Employee interfaces. Login credentials are managed via the database.

---

## 📂 Project Structure
```
Cafe_POS_System/
│
├── .vs/                            # Visual Studio internal files
├── AdminUC/                        # Admin user controls/forms
├── bin/                            # Build outputs
├── CustomerUC/                     # Customer user controls/forms
├── EmployeeUC/                     # Employee user controls/forms
├── obj/                            # Object files
├── packages/                       # NuGet packages
├── Properties/                     # Project properties
│
├── AdminForm.cs                   # Admin form code
├── AdminForm.Designer.cs          # Admin form designer
├── AdminForm.resx                 # Admin form resources
├── App.config                      # Application configuration
├── CMS.mdf                         # SQL Server database file
├── CMS_log.ldf                     # Database log file
├── CMSDataSet.Designer.cs          # Dataset designer
├── CMSDataSet.xsd                  # XML schema for dataset
├── CMSDataSet.xss                  # Dataset internal
├── Customer.cs                     # Customer class/form
├── Customer.txt                    # Possibly a text file for customer data or notes
├── Customer.Designer.cs            # Customer form designer
│
├── .gitignore                      # (Recommended to add)
└── README.md                       # This file
```
> **Note**: The project report is included as `22i-2667_22i-8758_Project_Report.pdf` (22 pages, covering requirements, ERD, EERD, normalization, documentation, and screenshots).

---

## 🧠 Core Modules & Features

### Admin Portal
- Manage Employees: Add/Edit/Delete employees, assign admins.
- Manage Discounts: Add/Edit/Delete discounts, view with products.
- Manage Orders: Add/Edit/Delete orders, view details, today's/last month's orders.
- Manage Products: Add/Edit/Delete products, view averages, low stock, sales.
- Manage Suppliers: Add/Edit/Delete suppliers, view supplied products, loyal/active suppliers.
- Admin Dashboard: Overview with user details and navigation.

### Employee Portal
- Manage Inventory: Add/Edit/Delete items, check low stock.
- Manage Orders (Employee): Add/Edit/Delete orders, view processing/pending.
- Manage Products (Employee): Add/Edit/Delete products, view discounted.
- Employee Dashboard: Overview with user details and navigation.

### Customer Portal
- Place Orders: Add to cart, adjust quantity, checkout.
- Payment: Select method, enter details, confirm.
- View Products: Search by ID/category, view details.
- View Discounts: Search and sort by discounts.
- View Orders: Check order details and status.
- Provide Feedback: Select type, comments, ratings (1-5).
- Customer Dashboard: Overview with user details and navigation.

- Database Features: ERD/EERD included in report; Normalized schema; SQL queries for CRUD and analytics (e.g., averages, counts).

---

## 🎯 Sample Usage

[Admin Login]

- Navigate to Manage Products > Add Product (ID, Name, Price, Category)
- View Dashboard for summaries

[Customer Login]

- View Products > Select Category > Add to Cart
- Proceed to Payment > Enter Card Details > Confirm Order
- Provide Feedback on experience

> Screenshots of interfaces and ERD are in the project report (pages 13-22).

---

## 🛠️ Setup & Installation

### 1. Clone the Repository
```bash
git clone https://github.com/AzghanAhmad/cafe-pos-system.git
cd cafe-pos-system
```

### 2. Requirements
- Visual Studio (with .NET desktop development workload).
- SQL Server (Express/LocalDB) for CMS.mdf.

### 3. Database Setup
- Attach CMS.mdf to SQL Server Management Studio (SSMS).
- Update connection string in App.config if needed (e.g., Data Source).

### 4. Build & Run
- Open in Visual Studio.
- Restore NuGet packages (if any in packages/).
- Build and run.

Dependencies: .NET Framework, System.Data.SqlClient (built-in).

**Database & Report Highlights**
- ERD/EERD: On pages 8-9 of the report – Entities include Employees, Products, Orders, Suppliers, Inventory, etc.
- Normalization: Checked up to 3NF/BCNF (page 10).
- User Documentation: Step-by-step help on pages 11-12.
- Screenshots: UI demos on pages 13+.

**Development Notes**
- Main Forms: AdminForm.cs, Customer.cs (likely includes Employee forms in UCs).
- Enhancements: Add reporting (e.g., PDF exports), cloud database (Azure SQL).
- Known Issues: Ensure database path is correct; Handle SQL exceptions.

---

## 🤝 Contributing

- Fork the repository
- Create a feature branch (`git checkout -b feature/new-feature`)
- Commit your changes (`git commit -m 'Add new feature'`)
- Push to the branch (`git push origin feature/new-feature`)
- Open a Pull Request

---

## ⚖️ License

MIT License – Free to use, modify, and distribute.  
See LICENSE for details.

---

## 👨‍💻 Author

Azghan Ahmad  
GitHub: @AzghanAhmad  
NUCES FAST, Islamabad  
November 16, 2025

