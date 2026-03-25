# 📚 USF Library Management System

## 👥 Team Members
- Harshitha  
- Koushik  
- Sushma  
- Prince  

---

## 📌 Introduction
This project implements a **Library Management System** using **Object-Oriented Programming (OOP)** principles in C#. The goal is to design a structured, scalable, and maintainable system that models real-world entities such as books, students, and staff.

The system demonstrates core OOP concepts:
- **Encapsulation**
- **Inheritance**
- **Abstraction**
- **Polymorphism**

---

## 🎯 Learning Objectives
- Understand and apply OOP principles in real-world scenarios  
- Design systems using classes, objects, and inheritance  
- Collaborate using Git and GitHub  
- Implement a functional library system  
- Follow best coding practices and version control workflows  

---

## 🏗️ System Design

### 📦 Classes Implemented

#### 1. Person (Base Class)
- Properties:
  - Name
  - Email
  - ID  

#### 2. Student (Inherits from Person)
- Additional Properties:
  - Major
  - GraduationYear  

#### 3. Staff (Inherits from Person)
- Additional Properties:
  - Position
  - Department  

#### 4. Book
- Properties:
  - Title
  - Author
  - ISBN
  - AvailableCopies  
- Methods:
  - BorrowBook()

#### 5. Library
- Manages:
  - Collection of books  
  - List of patrons  
- Methods:
  - DisplayBooks()
  - DisplayPatrons()

---

## ⚙️ Functionality

- Add new books and patrons  
- Borrow books  
- Return books  
- Display book details and availability  
- Display patron information  
- Validate book availability before borrowing  

---

## 🧪 Sample Scenario

### Initial Data

#### 📚 Books
- The Art of Data Strategy — 4 copies  
- Business Insights with AI — 3 copies  
- Analytics in Action — 6 copies  

#### 👨‍🎓 Students
- Akhil (S001)  
- Sandeep (S002)  

#### 👨‍💼 Staff
- Grandon Gill (ST001)  

---

### 🔄 Operations Performed

1. Sandeep borrows *Business Insights with AI*  
2. Akhil borrows *Analytics in Action*  

---

## 📊 Expected Output
Books in Library:
Title: The Art of Data Strategy, Author: Liam Reynolds, Available Copies: 4
Title: Business Insights with AI, Author: Olivia Carter, Available Copies: 3
Title: Analytics in Action, Author: Nathan Brooks, Available Copies: 6

Patrons in Library:
Name: Akhil, ID: S001
Name: Sandeep, ID: S002
Name: Grandon Gill, ID: ST001

Borrowing Books...
Sandeep borrowed 'Business Insights with AI'
Akhil borrowed 'Analytics in Action'

Books after borrowing:
Books in Library:
Title: The Art of Data Strategy, Author: Liam Reynolds, Available Copies: 4
Title: Business Insights with AI, Author: Olivia Carter, Available Copies: 2
Title: Analytics in Action, Author: Nathan Brooks, Available Copies: 5


---

## 🛠️ Project Structure
/LibraryManagementSystem
│── Person.cs
│── Student.cs
│── Staff.cs
│── Book.cs
│── Library.cs
│── Program.cs
│── README.md


---

## 🚀 Best Practices Followed

- Modular design with separate `.cs` files  
- Meaningful naming conventions  
- Use of inheritance to reduce redundancy  
- Regular commits and version control using GitHub  
- Collaborative development using branches  

---

## 📷 Submission Note
- The repository includes a screenshot of the program output  
- Only one team member submits the GitHub link on behalf of the group  

---

## 🏁 Conclusion
This project demonstrates how OOP concepts can be effectively used to build a real-world system. It also highlights teamwork, version control practices, and structured software development.

---
