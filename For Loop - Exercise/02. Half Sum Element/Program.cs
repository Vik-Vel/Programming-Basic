using System;

namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int maxNum = int.MinValue;
            int num = 0;


            for(int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());

                sum = sum + num;

                if (num > maxNum)
                {
                    maxNum = num;
                }
            }
            sum = sum - maxNum;

            if(maxNum == sum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum-maxNum)}");
            }
        }
    }
}
