using System;

namespace _03._Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int count = 0;
            for (int firstNum = 0; firstNum <= input; firstNum++)
            {
                for(int secondNum = 0; secondNum <= input; secondNum++)
                {
                    for(int thirdNum = 0; thirdNum <= input; thirdNum++)
                    {
                        if(firstNum+secondNum+thirdNum ==input )
                        {
                            count++;
                        }
                       
                    }
                }
            }

            Console.WriteLine($"{count}");





















            //int input = int.Parse(Console.ReadLine());
            //int counter = 0;
            //for (int firstNum = 0; firstNum <= input; firstNum++)
            //{
            //    for(int secondNum = 0; secondNum <= input; secondNum++)
            //    {
            //        for (int thirdNum = 0; thirdNum <= input; thirdNum++)
            //        {
            //            if (firstNum + secondNum + thirdNum == input)
            //            {
            //                counter++;
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine(counter);



        }
    }
}
