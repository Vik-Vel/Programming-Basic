using System;

namespace _01._Unique_PIN_Codes
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int limitfirstNum = int.Parse(Console.ReadLine());
            int limitsecondNum = int.Parse(Console.ReadLine());
            int limitthirdNum = int.Parse(Console.ReadLine());

            for(int num1 = 2;num1 <= limitfirstNum;num1+=2)
            {
                

                for(int num2 = 2;num2 <= limitsecondNum;num2++)
                {
                    if (num2 == 2 || num2 == 3 || num2 == 5 || num2 == 7)
                    {


                        for (int num3 = 2; num3 <= limitthirdNum; num3 +=2)
                        {

                            Console.WriteLine($"{num1} {num2} {num3}");
                        }
                    }
                }
            }


        }
    }
}
