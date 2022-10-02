using System;

namespace _02._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int firsNum = 1; firsNum <= 10; firsNum++)
            {
                for (int secondNum = 1; secondNum <= 10; secondNum++)
                {
                    Console.WriteLine($"{firsNum} * {secondNum} = {firsNum*secondNum}");
                }
            }



























            //for(int firstNum = 1; firstNum <= 10; firstNum++)
            //{
            //    for(int secondNum = 1; secondNum <= 10; secondNum++)
            //    {
            //        Console.WriteLine($"{firstNum} * {secondNum} = {firstNum*secondNum}");
            //    }
            //}



        }
    }
}
