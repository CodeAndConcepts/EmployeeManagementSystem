# 👥 Employee Management System (C# OOP Demo)

A simple console-based application demonstrating core **Object-Oriented Programming (OOP)** principles in C#.

This project was built as part of a personal upskilling plan to reinforce foundational design skills using **Encapsulation, Inheritance, Abstraction, and Polymorphism**.

---

## 🚀 Features

- Base `Employee` class with common properties
- Derived classes: `Manager`, `Developer`, `Intern`
- Custom salary calculation logic per role
- Virtual method overriding for dynamic behavior
- Clean and modular class structure
- Console-based report of employee details and salary

---

## 🧱 Project Structure

```bash
EmployeeManagementSystem/
├── Program.cs
├── EmployeeManagementSystem.csproj
├── Model/
│   ├── Employee.cs
│   ├── Manager.cs
│   ├── Developer.cs
│   └── Intern.cs
```
## 🔍 OOP Concepts Demonstrated
Principle	Implementation
Encapsulation	Private fields and public properties with controlled access
Inheritance	Manager, Developer, and Intern inherit from abstract Employee
Abstraction	Abstract method CalculateSalary() in Employee class
Polymorphism	Overridden methods used with a List<Employee> collection

## 🛠 Technologies Used
Language: C#
Runtime: .NET 8 (or compatible)
IDE: Visual Studio / VS Code

## ▶️ How to Run
1. Clone the repository:
```bash
git clone https://github.com/CodeAndConcepts/EmployeeManagementSystem.git
```
2. Open the solution in Visual Studio or VS Code.
3. Run the project (F5 or dotnet run).

## 🧩 Future Improvements
- Add IReportGenerator interface to demonstrate interface-based abstraction
- Separate UI/logic using service layers
- Add user interaction for runtime employee input
- Add unit tests for salary calculations

## 🧑‍💻 Author
[Yogesh] – Passionate about software design, currently reskilling with focus on C#, OOP, SOLID, and modern architecture.

## 📜 License
This project is licensed under the MIT License.
