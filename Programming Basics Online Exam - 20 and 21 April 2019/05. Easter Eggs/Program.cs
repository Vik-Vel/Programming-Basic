using System;

namespace _05._Easter_Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numColoredEgg = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            string maxx = "";
            int colorRed = 0;
            int colorOrange = 0;
            int colorBlue = 0;
            int colorGreen = 0;

            for (int i = 1; i <= numColoredEgg; i++)
            {
                string color = Console.ReadLine();

                if (color == "red")
                {
                    colorRed++;

                }
                else if (color == "orange")
                {
                    colorOrange++;

                }
                else if (color == "blue")
                {
                    colorBlue++;

                }
                else if (color == "green")
                {
                    colorGreen++;

                }


                if (colorRed > max)
                {
                    max = colorRed;
                    maxx = "red";

                }
                 if (colorOrange > max)
                {
                    max = colorOrange;
                    maxx = "orange";

                }
                 if (colorBlue > max)
                {
                    max = colorBlue;
                    maxx = "blue";

                }
                 if (colorGreen > max)
                {
                    max = colorGreen;
                    maxx = "green";

                }

            }
            
            Console.WriteLine($"Red eggs: {colorRed}");
            Console.WriteLine($"Orange eggs: {colorOrange}");
            Console.WriteLine($"Blue eggs: {colorBlue}");
            Console.WriteLine($"Green eggs: {colorGreen}");
            Console.WriteLine($"Max eggs: {max} -> {maxx}");

        }
    }
}
