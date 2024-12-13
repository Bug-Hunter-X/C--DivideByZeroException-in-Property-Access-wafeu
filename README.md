# C# DivideByZeroException Example

This repository demonstrates a common C# error: the `DivideByZeroException`. The `bug.cs` file contains code that can throw this exception.  The `bugSolution.cs` file provides a solution by implementing exception handling.

## Bug Description
The code attempts to divide by `MyProperty`, which may be zero, leading to the exception.

## Solution
The solution uses a `try-catch` block to catch the `DivideByZeroException`, preventing application crashes. A suitable error message is displayed instead.