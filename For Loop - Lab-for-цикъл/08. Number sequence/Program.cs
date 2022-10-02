﻿using System;

namespace _08._Number_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            int minNum = int.MaxValue;
            for(int counter = 0; counter < num; counter++)
            {
               int currentNum = int.Parse(Console.ReadLine()); 
                if(currentNum > maxNum)
                {
                    maxNum = currentNum;
                }

                if(currentNum < minNum)
                {
                    minNum = currentNum;
                }
            }
            Console.WriteLine($"Max number: {maxNum}");
            Console.WriteLine($"Min number: {minNum}");
           




        }
    }
}
