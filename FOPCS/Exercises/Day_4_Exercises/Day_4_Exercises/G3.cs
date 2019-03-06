using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_Exercises
{
    class G3
    {
        static void Main()
        {
            int[,] marks = new int[,] { { 56, 84, 68, 29 }, { 94, 73, 31, 96 }, { 41, 63, 36, 90 }, { 99, 9, 18, 17 }, { 62, 3, 65, 75 }, { 40, 96, 53, 23 }, { 81, 15, 27, 30 }, { 21, 70, 100, 22 }, { 88, 50, 13, 12 }, { 48, 54, 52, 78 }, { 64, 71, 67, 25 }, { 16, 93, 46, 72 } };
            int stun = marks.GetLength(0);
            int subn = marks.GetLength(1);


            int[] tstu = new int[stun];  //the total marks for each student
            double[] astu = new double[stun];  //average mark for each student
            for (int i = 0; i < stun; i++)
            {
                tstu[i] = 0;
                for (int j = 0; j < subn; j++)
                {
                    tstu[i] += marks[i, j];
                }
                astu[i] = tstu[i] / (double)subn; 
            }

            double[] asub = new double[subn];  //average mark for each subject
            for (int i = 0; i < subn; i++)
            {
                int sum = 0;
                for (int j = 0; j < stun; j++)
                {
                    sum += marks[j, i];
                }
                asub[i] = sum / (double)stun;
            }

            double[] sdsub = new double[subn];  //standard deviation for each subject
            for (int i = 0; i < subn; i++)
            {
                sdsub[i] = 0;
                for (int j = 0; j < stun; j++)
                {
                    sdsub[i] += Math.Pow(marks[j, i], 2);
                }
                sdsub[i] /= (double)stun;
                sdsub[i] = Math.Sqrt(sdsub[i]);
            }

            for (int i = 1; i <= subn; i++) Console.Write($"Subject{i}\t");
            Console.WriteLine("Total\t\tAvg");
            for (int i = 0; i < stun; i++)
            {
                for (int j = 0; j < subn; j++)
                {
                    Console.Write($"{marks[i, j]}\t\t");
                }
                Console.WriteLine($"{tstu[i]}\t\t{astu[i]}");
            }

            Console.WriteLine("\nAverage per subject: ");
            for (int i = 0; i < subn; i++)
            {
                Console.Write($"{asub[i]:#.####}\t\t");
            }
            Console.Write("\n");

            Console.WriteLine("\nStandard deviation per subject: ");
            for (int i = 0; i < subn; i++)
            {
                Console.Write($"{sdsub[i]:#.####}\t\t");
            }
            Console.Write("\n");
        }
    }
}
