﻿using System;

namespace _10._Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num >= 100 && num <= 200 && num != 0)
            {
                Console.WriteLine();
            }
            else if (num == 0)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("invalid");
            }

            //int num = int.Parse(Console.ReadLine());
            //if (num < 100 || num > 200)
            //{
            //    if (num != 0)
            //    {
            //        Console.WriteLine("invalid");
            //    }
            //}
        }
    }
}
