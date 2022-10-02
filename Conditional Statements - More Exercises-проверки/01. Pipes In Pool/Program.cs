using System;

namespace _01._Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int firstPipFor1 = int.Parse(Console.ReadLine());
            int secondPipFor1 = int.Parse(Console.ReadLine());
            double timeGone = double.Parse(Console.ReadLine());

            //napulneno kolichestvo za opredelenoto vreme
            double napulnila1Truba = timeGone *firstPipFor1;
            double napulnila2Truba = timeGone *secondPipFor1;

            double firstAndSecond = napulnila1Truba + napulnila2Truba;

            double neshto = (firstAndSecond - napulnila2Truba) ;


            if (firstAndSecond <= capacity)
            {
                Console.WriteLine($"The pool is {(firstAndSecond / capacity) * 100:f2}% full. Pipe 1: {(napulnila1Truba / firstAndSecond) * 100:f2}%. Pipe 2: {(napulnila2Truba / firstAndSecond) * 100:f2}%.");
            }
            
            else
            {
                Console.WriteLine($"For {timeGone} hours the pool overflows with {Math.Abs(capacity - firstAndSecond):f2} liters.");
            }


        }
    }
}
