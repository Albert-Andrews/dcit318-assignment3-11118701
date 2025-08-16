# DCIT 318 - Assignment 3

**Name:** Quaye Andrews Albert Awuley  
**Student ID:** 11118701  
**Course:** DCIT 318 - Programming II  
**GitHub Repository:** [dcit318-assignment3-11118701](https://github.com/Albert-Andrews/dcit318-assignment3-11118701.git)

---

## 📌 Overview
This repository contains **five separate C# console applications** demonstrating advanced concepts of **Object-Oriented Programming (OOP)**, **Generics**, **Collections**, **Exception Handling**, and **File I/O** in C#:

1. **Finance Management System (OOP & Polymorphism)**
2. **Healthcare System (Generics & Collections)**
3. **Warehouse Inventory Management (Interfaces & Custom Exceptions)**
4. **Grading System (File I/O & Exception Handling)**
5. **Inventory Records (Immutable Records & Persistence)**

---

## 📂 Project Structure

dcit318-assignment3-11118701/
│
├── Question1/
│ └── (Finance Management classes & interfaces)
│
├── Question2/
│ └── (Healthcare repository, Patient & Prescription classes)
│
├── Question3/
│ └── (Inventory items, repository & custom exceptions)
│
├── Question4/
│ └── (Student classes, exceptions & result processor)
│
├── Question5/
│ └── (Inventory record, entity interface & JSON logger)
│
├── Program.cs # Menu-driven entry point
├── dcit318-assignment3-11118701.csproj
└── README.md



## 📝 Question Details

### 1️⃣ Finance Management System
- Demonstrates **OOP, interfaces, inheritance, polymorphism, and sealed classes**.  
- Supports different transaction processors:  
  - **Mobile Money**
  - **Bank Transfer**
  - **Crypto Wallet**

### 2️⃣ Healthcare System with Generics
- Uses **generic repository pattern**.  
- Manages patients and prescriptions efficiently with type safety.  

### 3️⃣ Warehouse Inventory Management
- Demonstrates **interfaces, generics, and custom exceptions**.  
- Handles:  
  - Duplicate items  
  - Item not found  
  - Invalid quantity  

### 4️⃣ Grading System with File I/O
- Reads input from `students_input.txt`.  
- Validates missing fields and incorrect score formats with exceptions.  
- Generates report `students_report.txt`.  

### 5️⃣ Inventory Records with Persistence
- Uses **immutable record types** for inventory items.  
- Saves and loads records using **JSON serialization**.  

---

## ▶ How to Run
1. Clone this repository:
   ```bash
   git clone https://github.com/Albert-Andrews/dcit318-assignment3-11118701.git.git
   cd dcit318-assignment3-11118701
   dotnet run
