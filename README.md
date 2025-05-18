# Sales Tracking App
**By: Deborah Schonkopf**

---

## Overview

This JudaicaOrderForm is a C# Windows Forms application that simulates a sales tracking system for a Judaica store. It enables users to:

- Log in with a username and password
- Browse available store items
- Make purchases in custom quantities
- Track outstanding balances and make payments
- View and filter purchase history

All data is stored in a **SQL Server database** and accessed via **LINQ-to-SQL**.

---

## Features

- Multi-user login with password verification  
- Browse and purchase items with quantity control  
- Enforced credit limit: balance cannot exceed $250  
- Make partial or full payments toward account balance  
- Filter purchase history by date and price range  
- Clear UI using ListView and ComboBox controls  
- Efficient LINQ extension method queries

---

## Tech Stack

- C# (.NET Framework - WinForms)
- SQL Server (local DB: `StoreDB`)
- LINQ-to-SQL (`StoreDB.dbml`)
- Visual Studio 2022

---

## How to Run

1. Clone or download this repository  
2. Open `FinalProject.sln` in **Visual Studio**
3. Ensure SQL Server is running and `StoreDB` is attached
4. (Optional) Update `App.config` with your SQL connection string
5. Press `F5` or click **Start** to run

---

## Project Structure
FinalProject/
├── Forms/
│ ├── LoginForm.cs
│ ├── MainForm.cs
│ ├── PurchaseForm.cs
│ ├── BalanceForm.cs
│ └── HistoryForm.cs
├── StoreDB.dbml # LINQ-to-SQL model
├── Program.cs # Application entry point
├── App.config # DB connection
├── FinalProject.sln
└── README.md


---

## Notes

- Purchases are recorded but not paid at time of order  
- Users are blocked from purchasing if their balance exceeds `$250.00`
- Filtering supports precise decimal inputs (e.g., `18.75`)
- All UI forms cleanly close and dispose of resources

---

## Possible Future Enhancements

- Admin panel to view all users and manage store inventory
- Export purchase history to CSV or PDF
- Enhanced login with password hashing and roles

---

## Developed for:

> **Advanced Topics in Object-Oriented Programming**  
> Touro University, Spring 2025

