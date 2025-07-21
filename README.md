# Guest Book – C# Console App

This C# console application that simulates a guest book for party check-ins. It was built as part of my journey to learn C# and .NET fundamentals, focusing on user input, loops, validation, and basic data structures like dictionaries.

---

## 📚 What It Does

The program:

- Greets the user with a welcome message
- Prompts for the name of a party
- Asks how many people are in the party
- Repeats until no more entries are needed
- Displays a summary of all parties and the total guest count

---

## 🧠 What I Learned

- Creating and using **static methods** in C#
- Structuring code with reusable helper methods
- Validating user input using `int.TryParse()`
- Collecting data using a **`Dictionary<string, int>`** to map party names to guest sizes
- Using **top-level statements** for a clean `Program.cs`
- Separating logic into a dedicated class (`GuestBookLogic`) for maintainability

---

## 🚀 How to Run It

1. Clone the repository:

   ```bash
   git clone https://github.com/your-username/guestbook-console-csharp.git
   cd guestbook-console-csharp

   Build and run the app using the .NET CLI:
   ```

bash
Copy
Edit
dotnet run
Follow the prompts in the console to add party names and guest counts.

🧩 Sample Output

```
Welcome to the guest book app
-----------------------------

What is the name of your party? Neill Family
How many people are in your party? 4
Are there any more parties to enter? (y/n): y

What is the name of your party? Smiths
How many people are in your party? 3
Are there any more parties to enter? (y/n): n

Tonight's parties include:
- Neill Family: 4
- Smiths: 3

Total number of guests: 7
```

🛠️ Tech Stack
C#

.NET Console App

VS Code

🔄 Future Improvements (Stretch Goals)
Create a Party class to encapsulate name and guest count

Sort parties alphabetically before displaying

Add input validation for empty or duplicate names

Write unit tests for helper methods

Save guest data to a file or database

Add error handling for empty input or edge cases

📂 File Overview
Program.cs – Main entry point of the app using top-level statements

GuestBookLogic.cs – Contains all helper methods for handling input, data collection, and display logic

✍️ Author
DJ Neill
