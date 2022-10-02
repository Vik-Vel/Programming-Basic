using System;

namespace _07._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfInputs = int.Parse(Console.ReadLine());
            int sumOfNumbers = 0;

            for(int counter = 0; counter < countOfInputs; counter++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                sumOfNumbers += currentNum; 
            }

            Console.WriteLine(sumOfNumbers);


        }
    }
}
