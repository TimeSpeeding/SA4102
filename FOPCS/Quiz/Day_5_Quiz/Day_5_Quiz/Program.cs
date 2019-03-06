using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Quiz
{
    class Program
    {
        static int[] minIncomeArray = new int[]
        { 20000, 30000, 40000, 80000, 120000, 160000, 200000, 320000 };
        static double[] taxRateArray = new double[]
        { 0.02, 0.035, 0.07, 0.115, 0.15, 0.17, 0.18, 0.20 };
        static int[] basePayableAmountArray = new int[]
        { 0, 200, 550, 3350, 7950, 13950, 20750, 42350 };
        static void Main(string[] args)
        {
            int annualIncome = AskForIncome();
            int taxBracket = GetTaxBracket(annualIncome);
            //Console.WriteLine(taxBracket);
            double taxPayable = CalculateIncomeTax(annualIncome, taxBracket);
            PrintResult(annualIncome, taxPayable);
        }
        static int AskForIncome()
        {
            Console.Write("Please enter your income: ");
            return int.Parse(Console.ReadLine());
        }
        static int GetTaxBracket(int ann)
        {
            int i = 0;
            if (ann > 320000) i = 8;
            else
            {
                while (ann > minIncomeArray[i]) i++;
            }
            return i - 1;
        }
        static double CalculateIncomeTax(int ann, int tb)
        {
            if (ann <= 20000) return 0;
            else return basePayableAmountArray[tb] + (ann - minIncomeArray[tb]) * taxRateArray[tb];
        }
        static void PrintResult(int ann, double tax)
        {
            Console.WriteLine($"For taxable annual income of ${ann:#,0.00}, the tax payable amount is ${tax:#,0.00}");
        }
    }
}
