using System;

namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int sumAll = 0;

            while(input > sumAll)
            {
               int inputs = int.Parse(Console.ReadLine());
                sumAll += inputs;
              
                
            }
            Console.WriteLine(sumAll);


            //int num = int.Parse(Console.ReadLine());

            //int numAll = 0;

            //while (num > numAll )
            //{
            //    int nums = int.Parse(Console.ReadLine());
            //    numAll += nums;

            //}

            //Console.WriteLine(numAll);
        }
    }
}
