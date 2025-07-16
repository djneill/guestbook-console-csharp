# Guest Book - C# Console App

This is a beginner-level C# console application that simulates a guest book for party check-ins. It was built as part of my journey learning C# and .NET fundamentals, with a focus on user input, loops, conditional logic, and basic data structures.

## 📚 What It Does

The program:

- Prompts the user to enter the name of a party.
- Asks how many guests are in that party.
- Repeats until the user is done entering parties.
- Then displays a summary of all party names and the total number of guests.

## 🧠 What I Learned

- Creating and using **static methods** in C#
- Collecting and validating **user input** from the console
- Managing collections using a **`List<string>`**
- Performing basic **input validation** with `int.TryParse`
- Structuring code across multiple files with a `Messages` class for cleaner organization

## 🚀 How to Run It

1. Clone the repo:
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
sql
Copy
Edit
Welcome, what is the name for your party? Neill Family
How many are in your party? 4
Are there any more parties to enter? y/n: y

Welcome, what is the name for your party? Smiths
How many are in your party? 3
Are there any more parties to enter? y/n: n

The parties for today are:
Neill Family
Smiths
We have a total of 7 guest.
🛠️ Tech Stack
C#

.NET Console App

Visual Studio / VS Code / .NET CLI

🔄 Future Improvements (Stretch Goals)
Store entries as objects with both name and guest count

Sort parties alphabetically

Save guest data to a file or database

Add error handling for empty input or edge cases

📂 File Overview
Program.cs - Main execution loop that drives the app

Messages.cs - Helper methods for interacting with the user

✍️ Author
DJ Neill
