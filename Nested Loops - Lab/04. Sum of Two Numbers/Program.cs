using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            bool magicNumFound = false;

            int counter = 0;
            for(int firstNum = start; firstNum <= end; firstNum++)
            {
                for(int secondNum = start; secondNum <= end; secondNum++)
                {
                    counter++;

                    if (firstNum+secondNum == magicNum)
                    {
                        magicNumFound = true;
                        Console.WriteLine($"Combination N:{counter} ({firstNum} + {secondNum} = {magicNum})");
                        break;


                    }
                   
                  
                }
                if (magicNumFound)
                {
                    break;
                }
            }
            if (!magicNumFound)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
            }

















            //int start = int.Parse(Console.ReadLine());
            //int end = int.Parse(Console.ReadLine());
            //int magicNum = int.Parse(Console.ReadLine());

            //int combination = 0;
            //bool MagicNumFound = false;
           
            //for(int firstNum = start; firstNum <= end; firstNum++)
            //{
            //    for(int secondNum = start; secondNum <= end; secondNum++)
            //    {
            //        combination++;
            //        if(firstNum + secondNum == magicNum)
            //        {
            //            MagicNumFound = true;
            //            Console.WriteLine($"Combination N:{combination} ({firstNum} + {secondNum} = {magicNum})");
            //            break;
            //        }
            //    }
            //    if(MagicNumFound)
            //    {
            //        break;
            //    }
            //}
            //if(!MagicNumFound)
            //{
            //    Console.WriteLine($"{combination} combinations - neither equals {magicNum}");

            //}




        }
    }
}
