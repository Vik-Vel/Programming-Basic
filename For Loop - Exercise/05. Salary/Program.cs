﻿using System;

namespace _05._Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());


           string site = string.Empty;

            for(int i = 1; i <= n; i++)
            {
                site = Console.ReadLine();
                if(site == "Facebook")
                {
                    salary = salary - 150;
                }
                else if(site == "Instagram")
                {
                    salary = salary - 100;
                }
                else if(site == "Reddit")
                {
                    salary = salary - 50;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }

            if (salary > 0)
            {
                Console.WriteLine(Math.Round(salary));
            }
        }
    }
}
