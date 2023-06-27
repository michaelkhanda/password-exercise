using System;

namespace Passwordexercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a password:");
            string password = Console.ReadLine();

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Please re-enter the password:");
                string attempt = Console.ReadLine();
                if (password == attempt)
                {
                    Console.WriteLine("Password Authenticated!");
                    break;
                }
                else
                {
                    Console.Write("Password Incorrect!");
                }
                if (i == 3)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Password Incorrect,Maximum number of attempts reached!");
                    Console.ResetColor();
                }
            }
        }
    }
}