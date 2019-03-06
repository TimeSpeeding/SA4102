using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_Exercises
{
    class G7
    {
        static void Main()
        {
            string[] name = new string[] { "Bob", "Dennis", "Frank", "Alice", "Charlie", "Eli", "Gina" };
            int[] score = new int[] { 90, 80, 66, 100, 120, 76, 88 };

            for (int i = 0; i < name.Length - 1; i++)
            {
                for (int j = i + 1; j < name.Length; j++)
                {
                    if (name[i].CompareTo(name[j]) == 1)
                    {
                        string tempn = name[i]; name[i] = name[j]; name[j] = tempn;
                        int temps = score[i]; score[i] = score[j]; score[j] = temps;
                    }
                }
            }

            Console.WriteLine("Name\tScore");
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine($"{name[i]}\t{score[i]}");
            }
        }
    }
}
