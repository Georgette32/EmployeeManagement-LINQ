# EmployeeManagement - LINQ Part 1

## 📌 Project Description
A C# Console Application to practice Object-Oriented Programming (OOP), Collections, Delegates, and LINQ operations on a list of employees.

## 🚀 Features
- Create and manage a list of employees.
- Filter employees using `Where()`.
- Select specific data using `Select()`.
- Find employees using:
  - `FirstOrDefault()`
  - `LastOrDefault()`
  - `SingleOrDefault()`
- Sort employees using:
  - `OrderBy()`
  - `OrderByDescending()`
  - `ThenBy()`
- Check conditions using:
  - `Any()`
  - `All()`
  - `Count()`
- Implement a Repository class with:
  - `GetHighSalaryEmployees()`

## 🛠 Concepts Used
- C#
- OOP
  - Classes & Objects
  - Encapsulation
  - Inheritance
  - Polymorphism
  - Interfaces
- Collections
  - List
  - Dictionary
- Delegates
- Lambda Expressions
- LINQ

## 📂 Project Structure
```text
EmployeeManagement
│
├── Models
│   └── Employee.cs
│
├── Repository
│   └── Repository.cs
│
└── Program.cs
```

## ▶️ Example
```csharp
var highSalaryEmployees =
    repo.GetHighSalaryEmployees(10000);
```

## 👩‍💻 Author
Georgette Nagy
Computer Science Student | .NET Backend Developer Trainee  ## 🎯 Learning Goals
- Practice LINQ instead of loops.
- Understand how to use delegates and lambda expressions.
- Apply OOP concepts in a real project.
