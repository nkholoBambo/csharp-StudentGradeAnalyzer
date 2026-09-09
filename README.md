# csharp-StudentGradeAnalyzer
A console application made using LINQ

Losman Student Grade Analyzer
A C# console application that uses LINQ to query and analyze a list of students and their marks — filtering, sorting, and aggregating data instead of manually looping and tracking state.

What it does:
-Stores a List<Student>, each with a Name and Mark
-Uses LINQ (query syntax) to:
-Filter students who passed (mark ≥ 50)
-Find the top-performing student, sorted by mark descending
-Calculate the class average mark
-Prints the passing students, the top student, and the class average

Tech used
-C#
-.NET Console Application
-How to run
   1. Clone this repo
   2. Navigate to the project folder
   3. Run:
      dotnet run

Concepts practiced:
-LINQ query syntax (from ... where ... select, orderby ... descending)
-List<T>.Average()
-FirstOrDefault() used instead of First() to safely handle an empty result without throwing an exception
-Custom class (Student) used as the element type in a LINQ query

Note
LINQ can be written in two equivalent styles: query syntax (used here, reads similarly to SQL) and method syntax (.Where(), .OrderByDescending(), chained directly on the collection). Both compile to the same result — query syntax was chosen here deliberately as practice, and method syntax is worth being equally comfortable with, since it's more common in production C# code.
