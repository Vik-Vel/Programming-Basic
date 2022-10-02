using System;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char oper = char.Parse(Console.ReadLine());

            if (oper == '+' )
            {
                double sum = n1 + n2;

                if(sum % 2 == 0)
                {
                    Console.WriteLine($"{n1} + { n2} = {sum} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} + { n2} = {sum} - odd");
                }
                
            }

            else if ( oper == '-' )
            {
                double sum = n1 - n2;

                if (sum % 2 == 0)
                {
                    Console.WriteLine($"{n1} - { n2} = {sum} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} - { n2} = {sum} - odd");
                }
            }

            else if(oper == '*')
            {
                double sum = n1 * n2;

                if (sum % 2 == 0)
                {
                    Console.WriteLine($"{n1} * { n2} = {sum} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} * { n2} = {sum} - odd");
                }
            }
            else if (oper == '/')
            {
                if(n2 == 0)
                {
               
                    Console.WriteLine($"Cannot divide {n1} by zero");

                }
                else
                {
                    double sum = 1.0*n1 / n2;
                    Console.WriteLine($"{n1} / { n2} = {sum:f2}");
                }
               
               
            }
            else
            {
               

                if (n2 == 0)
                {

                    Console.WriteLine($"Cannot divide {n1} by zero");

                }
                else
                {
                   
                    double sum = 1.0 * n1 % n2;
                    Console.WriteLine($"{n1} % { n2} = {sum}");
                }
            }



        }
    }
}
