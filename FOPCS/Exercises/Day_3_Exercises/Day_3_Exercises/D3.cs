using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Exercises
{
    class D3
    {
        static void Main()
        {
            Random rnd = new Random();
            int num = rnd.Next(10);       //get a random integer number from 0 to 9
            int times = 0;                //the times you guess
            int guess = 10;               //because num cannot be 10, this is a safe start for guess
            while (guess != num)
            {
                if (times > 0)
                {
                    Console.WriteLine("Sorry! It is a wrong guess.\nPlease try again!\n");
                }
                Console.Write("Enter the number you guess: ");
                guess = int.Parse(Console.ReadLine());
                times++;
            }
            Console.WriteLine("Congratuations! You made the correct guess.");
            if (times < 3)
            {
                Console.WriteLine("You are a Wizard!");
            }
            else if (times < 6)
            {
                Console.WriteLine("You are a good guess.");
            }
            else
            {
                Console.WriteLine("You are lousy!");
            }
        }
    }
}
