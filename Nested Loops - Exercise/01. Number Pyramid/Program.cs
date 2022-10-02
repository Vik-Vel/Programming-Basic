using System;

namespace _01._Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int counter = 1;

            for(int first = 1; first <= num; first++)
            {
                for(int second =1 ; second <= first; second++)
                {
                    Console.Write($"{counter + " "}");
                    counter++;
                    
                    if(counter > num)
                    {
                        break;
                    }

                }
                Console.WriteLine();
                if (counter > num)
                {
                    break;
                }
            }




























            //int num = int.Parse(Console.ReadLine());
            //int currNum = 1;

            //for (int rows = 1; rows <= num; rows++) 
            //{
            //    for (int nums = 1; nums <= rows; nums++) 
            //    {
            //        Console.Write(currNum + " ");
            //        currNum++;
            //        if (currNum > num)
            //        {
            //            break;
            //        }
            //    }
            //    Console.WriteLine();
            //    if(currNum > num)
            //    {
            //        break;
            //    }
            //}

        }
    }
}
