using System;

namespace _01._Excellent_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            double currenScore = double.Parse(Console.ReadLine());

            bool isExellentScore = currenScore >= 5.5;

            if (isExellentScore)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
