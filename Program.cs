using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "WebLorat";
            string appVersion = "1.0.0";
            string appAuthor = "Loratadin Legacy";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            string name = "Loratadin Legacy";
            int age = 35;
            Console.ResetColor();
            Console.WriteLine("{0} is {1}", name, age);
            Console.WriteLine("What is your name?");
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game", inputName);
            //int correctNumber = 7;
            Random random = new Random();
            int correctNumber = random.Next(1, 10);
            int guess = 0;
            Console.WriteLine("Guess a number between 1 and 10");
            while (guess != correctNumber)
            {
                string input = Console.ReadLine();
                if(!int.TryParse(input, out guess)) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please, enter an actual number");
                    Console.ResetColor();
                    continue;
                }
                guess = Int32.Parse(input);
                if (guess != correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong number, please try again");
                    Console.ResetColor();
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You are CORRECT!!!");
            Console.ResetColor();
        }
    }
}