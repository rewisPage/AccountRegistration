# Account Registration System (Windows Forms)

A desktop-based student registration application built using C# and .NET Windows Forms. This laboratory exercise demonstrates the practical implementation of **custom delegates**, **static classes**, **form-to-form data transfer**, and **modal dialog handling**.

---

## 🎯 Objectives
* Declare, instantiate, and invoke delegates in C#.
* Pass and retrieve data between multiple Windows Forms using static classes and delegate references.
* Implement input validation and control error handling.
* Manage modal dialog lifecycles using `ShowDialog()` and `DialogResult`.

---

## 🛠️ Technologies Used
* **Language:** C#
* **Platform:** .NET Framework (Windows Forms)
* **IDE:** Visual Studio Community 2015 or higher

---

## 📂 Project Structure

```text
AccountRegistration/
│
├── StudentInfoClass.cs    # Static repository holding student data, delegates, and getter methods
├── FrmRegistration.cs     # Main input form for capturing student details
├── FrmRegistration.Designer.cs
├── FrmConfirm.cs          # Modal confirmation form displaying details via delegates
├── FrmConfirm.Designer.cs
└── Program.cs             # Application entry point
```

---

## ⚙️ How It Works

1. **Data Entry (`FrmRegistration`):**
   * Accepts user inputs for: Student No., Program, Last Name, First Name, Middle Name, Age, Contact No., and Address.
   * Validates that all fields are filled and that numerical values (`StudentNo`, `Age`, `ContactNo`) are properly formatted.
   * Assigns values to static variables defined in `StudentInfoClass`.

2. **Delegates & Retrieval (`StudentInfoClass`):**
   * Two public delegates are declared: `DelegateText(string txt)` and `DelegateNumber(long number)`.
   * Static getter methods return each stored property.

3. **Confirmation View (`FrmConfirm`):**
   * Instantiates delegate instances bound to the static getter methods of `StudentInfoClass`.
   * Invokes the delegates during the form's `Load` event to populate display labels dynamically.
   * Closes with `DialogResult.OK` upon clicking **Submit** or closing the form.

4. **Reset Workflow:**
   * Upon receiving `DialogResult.OK` from `FrmConfirm.ShowDialog()`, `FrmRegistration` clears all text boxes and resets the combo box.

---

## 🚀 Getting Started

1. Clone or download this repository.
2. Open the solution file (`.sln`) in **Visual Studio**.
3. Build the solution (`Ctrl + Shift + B`) to verify all references.
4. Press `F5` or click **Start** to run the application.

---

## 📋 Evaluation Rubric
* **Correctness (30%):** The code produces the expected result.
* **Logic (30%):** The code meets the specifications of the problem.
* **Efficiency (20%):** The code is concise without sacrificing correctness and logic.
* **Syntax (20%):** The code adheres to the rules of the programming language.
