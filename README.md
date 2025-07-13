# PracticeOops

## Introduction
This project is designed to help you implement and practice object-oriented programming (OOP) concepts in C#. It provides a collection of example programs that demonstrate various OOP principles, such as classes, inheritance, encapsulation, and polymorphism. Additionally, the project integrates NUnit testing to ensure code correctness and to help you learn unit testing practices in C#.

## Folder Structure
```
PracticeOops.csproj
PracticeOops.sln
Src/
    ArrayPractice.cs
    Arrays.cs
    BubbleSortProgram.cs
    CollectionsInCSharp.cs
    DuplicateLetters.cs
    HowManyTimes.cs
Tests/
    ArrayPracticeTest.cs
    BubbleSortTest.cs
    DuplicateLettersTest.cs
    StringReverseTest.cs
```

- **Src/**: Contains all the C# source code files implementing various OOP examples and algorithms.
- **Tests/**: Contains NUnit test files for each respective class in the `Src` folder. These tests allow you to run and verify the implementation of each program individually.

## How to Use
1. Explore the `Src` folder to review and learn from the C# code examples.
2. Use the test files in the `Tests` folder to run NUnit tests and check the correctness of each implementation.
3. Build and run the solution using Visual Studio or the .NET CLI.

## Getting Started
- Open the solution file (`PracticeOops.sln`) in Visual Studio.
- Restore NuGet packages if required.
- Build the project to ensure all dependencies are resolved.
- Run the tests using the Test Explorer in Visual Studio or by using the .NET CLI:
  ```
  dotnet test
  ```

## License
This project is for educational purposes and does not include a specific license.

## Running Tests from the Command Line

To run all NUnit tests using the .NET CLI, follow these steps:

1. Open a terminal or command prompt.
2. Navigate to the project root directory (where `PracticeOops.sln` is located):
   ```powershell
   cd path\to\CSharpPracticeCode
   ```
3. Run the following command to execute all tests:
   ```powershell
   dotnet test
   ```

This will build the project and run all tests in the `Tests` folder. The results will be displayed in the terminal.
