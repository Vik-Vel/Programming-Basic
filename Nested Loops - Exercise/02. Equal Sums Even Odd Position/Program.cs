using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int num = start; num <= end; num++)
            {
                int currNum = num;
                int evenSum = 0;
                int oddSum = 0;
                int count = 0;

                while (currNum != 0)
                {
                    int digit = currNum % 10;
                    if (count % 2 == 0)
                    {
                        evenSum += digit;
                    }
                    else
                    {
                        oddSum += digit;
                    }
                    currNum /= 10;
                    count++;
                }
                if (evenSum == oddSum)
                {
                    Console.Write($"{num} ");
                }



            }




















            //int numOne = int.Parse(Console.ReadLine());
            //int numTwo = int.Parse(Console.ReadLine());


            //for(int i = numOne; i <= numTwo; i++)
            //{
            //    int even = 0;
            //    int odd = 0;   
            //    string next = Convert.ToString(i);
            //    for(int j = 0; j < next.Length; j++)
            //    {
            //        char currNum = next[j];
            //        if (j % 2 ==0)
            //        {
            //            even += currNum;
            //        }
            //        else
            //        {
            //            odd += currNum;
            //        }

            //    }
            //    if (even == odd)
            //    {
            //        Console.Write($"{next} ");
            //    }
            //}





























            //int intervalStart = int.Parse(Console.ReadLine());
            //int intervalEnd = int.Parse(Console.ReadLine());
            //for (int i = intervalStart; i <= intervalEnd; i++)
            //{
            //    int even = 0;
            //    int odd = 0;
            //    string next = Convert.ToString(i);
            //    for (int j = 0; j < next.Length; j++)
            //    {
            //        char currNum = next[j];
            //        if (j % 2 == 0)
            //        {
            //            even += currNum;
            //        }
            //        else
            //        {
            //            odd += currNum;
            //        }

            //    }
            //    if (even == odd)
            //    {
            //        Console.Write($"{next} ");
            //    }
            //}
        }
    }
}


