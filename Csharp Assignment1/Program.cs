using System;
using ConsoleApp1;

namespace Csharp_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, welcome to Chatbox, Let's Chat!");
            Console.WriteLine("Enter your FullName");
            string FullName = Console.ReadLine();

            Console.WriteLine("Hello " + FullName + " Get Transaction Details");
            var BankAccount = new AccountDetails();
            Console.WriteLine(BankAccount);
        }
    }
}
