using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int tournaments = int.Parse(Console.ReadLine()); 
            int startPoints = int.Parse(Console.ReadLine());

            double allPoints = startPoints;
            double averagePoints = 0;
            double win = 0;

            for(int i = 1; i <= tournaments; i++)
            {
                string stage = Console.ReadLine();

                if (stage == "W")
                {
                    allPoints = allPoints + 2000;
                    win += 1;
                }

                else if (stage == "F")
                {
                    allPoints = allPoints  + 1200;
                }

                else
                    allPoints = allPoints + 720;

            }

            averagePoints = (allPoints-startPoints) / tournaments;
            win = win / tournaments * 100.00;


            Console.WriteLine($"Final points: {allPoints}");
            Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
            Console.WriteLine($"{win:f2}%");



        }
    }
}
