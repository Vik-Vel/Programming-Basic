using System;

namespace _05._Easter_Bake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numEasterBread = int.Parse(Console.ReadLine());
          

            double allQuanSugar = 0;
            double allQuanFlour = 0;

            double numPackSugar = 0;
            double numPackFlour = 0;

            int maxSugar = int.MinValue;
            int maxFlour = int.MinValue;

            for(int i = 1; i <= numEasterBread; i++)
            {
                int quanSugar = int.Parse(Console.ReadLine());
                int quanFlour = int.Parse(Console.ReadLine()); 
                allQuanSugar = allQuanSugar + quanSugar;
                allQuanFlour = allQuanFlour + quanFlour;


                if(quanSugar > maxSugar)
                {
                    maxSugar = quanSugar;
                }

                if(quanFlour > maxFlour)
                {
                    maxFlour = quanFlour;
                }

                 //quanSugar = int.Parse(Console.ReadLine());
                 //quanFlour = int.Parse(Console.ReadLine());



            }

            numPackSugar = Math.Ceiling( allQuanSugar / 950);
            numPackFlour = Math.Ceiling(allQuanFlour / 750);

            Console.WriteLine($"Sugar: {numPackSugar}");
            Console.WriteLine($"Flour: {numPackFlour}");
            Console.WriteLine($"Max used flour is {maxFlour} grams, max used sugar is {maxSugar} grams.");









        }
    }
}
