using System;

namespace _03._Sum_Prime_Non_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int sumPrime = 0;
            int sumNoPrime = 0;
            int num;

            while (input != "stop")
            {
                num = int.Parse(input);


                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }
                bool isPrime = true;

                for (int i = 2; i < num - 1; i++)
                {
                    if (num % 1 == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    sumPrime = sumPrime +  num;
                }
                else
                {
                    sumNoPrime = sumNoPrime + num;
                }
                input = Console.ReadLine();

            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNoPrime}");



























            //string input = Console.ReadLine();
            //int num;

            //int sumPrime = 0;
            //int sumNotPrime = 0;

            //while (input != "stop")
            //{
            //    num = int.Parse(input);

            //    if (num < 0)
            //    {
            //        Console.WriteLine("Number is negative.");
            //        input = Console.ReadLine();
            //        continue;
            //    }
            //    bool isPrime = true;

            //    for (int i = 2; i < num - 1; i++)
            //    {
            //        if (num % i == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //    if (isPrime)
            //    {
            //        sumPrime += num;
            //    }
            //    else
            //    {
            //        sumNotPrime += num;
            //    }

            //    input = Console.ReadLine();
            //}

            //Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            //Console.WriteLine($"Sum of all non prime numbers is: {sumNotPrime}");


        }
    }
}