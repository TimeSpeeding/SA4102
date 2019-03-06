using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = 123456;
            Console.WriteLine("Welcome to the Bank of ISS");
            Console.Write("Enter your PIN: ");
            int input = int.Parse(Console.ReadLine());
            int times = 1;

            while (true)
            {
                if (input == key)
                {
                    Console.WriteLine("\nPIN accepted. You can access your account now.");
                    break;
                }
                else
                {
                    if (times < 3)
                    {
                        Console.WriteLine("\nIncorrect PIN. Please try again.");
                        Console.Write("Enter your PIN: ");
                        input = int.Parse(Console.ReadLine());
                        times++;
                    }
                    else if (times == 3)
                    {
                        Console.WriteLine("\nToo many wrong PIN entries. Your account is now locked.");
                        break;
                    }
                }
            }
        }
    }
}
