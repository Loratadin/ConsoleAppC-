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
            string input = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game", input);

        }
    }
}
