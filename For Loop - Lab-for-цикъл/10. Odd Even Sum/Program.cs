using System;

namespace _10._Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int num = int.Parse(Console.ReadLine());
            int sumOdd = 0;
            int sumEven = 0;

            for (int i = 1; i <= num; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEven += currentNum;
                }
                else
                {
                    sumOdd += currentNum;
                }
            }
                if(sumEven == sumOdd)
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine($"Sum = {sumEven}");
                }
                else
                {
                    Console.WriteLine("No");
                    Console.WriteLine($"Diff = {Math.Abs(sumEven-sumOdd)}");
                }

            




        }
    }
}
