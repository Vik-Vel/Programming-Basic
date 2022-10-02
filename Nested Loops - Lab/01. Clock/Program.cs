using System;

namespace _01._Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int hours = 0; hours <= 23; hours++)
            {
                for(int minutes = 0; minutes <=59; minutes++)
                {
                    Console.WriteLine($"{hours:d2}:{minutes:d2}");
                }
            }








            














            //for (int firstNum = 0; firstNum <= 23; firstNum++)
            //{
            //    for(int secondNum = 0; secondNum <= 59; secondNum++)
            //    {
            //        Console.WriteLine($"{firstNum}:{secondNum}");
            //    }
            //}
               

        }
    }
}
