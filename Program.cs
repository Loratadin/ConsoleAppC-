﻿using System;
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
            GetAppInfo();
            GreetUser();
            while (true) { 
                Random random = new Random();
                int correctNumber = random.Next(1, 10);
                int guess = 0;
                Console.WriteLine("Guess a number between 1 and 10");
                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();
                    if(!int.TryParse(input, out guess)) {
                        PrintColorMessage(ConsoleColor.Red, "Please, enter an actual number");
                        continue;
                    }
                    guess = Int32.Parse(input);
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }
                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!!!");
                Console.WriteLine("Play again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y") {
                    continue;
                } else if (answer == "N") {
                    return;
                } else {
                    return;
                }
            }
        }
        static void GetAppInfo() {
            string appName = "WebLorat";
            string appVersion = "1.0.0";
            string appAuthor = "Loratadin Legacy";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }
        static void GreetUser() {
            Console.WriteLine("What is your name?");
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game", inputName);
        }
        static void PrintColorMessage(ConsoleColor color, string message) {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}