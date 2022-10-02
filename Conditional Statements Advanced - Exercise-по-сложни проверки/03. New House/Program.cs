using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int numFlowers = int.Parse(Console.ReadLine());
            int budgete = int.Parse(Console.ReadLine());

            double rose = 5;
            double dahlia = 3.80;
            double tulip = 2.80;
            double narcissus = 3;
            double gladiolus = 2.50;

            double totalPrice = 0.0;
     
            switch(flowers)
            {
                case  "Roses":
                   if(numFlowers > 80)
                    {
                        totalPrice = (numFlowers * rose) * 0.9;
                    }
                   else
                    {
                        totalPrice = (numFlowers * rose);
                    }
                        break;



                case  "Dahlias":
                    if (numFlowers > 90)
                    {
                        totalPrice = (numFlowers * dahlia) * 0.85;
                    }
                    else
                    {
                        totalPrice = (numFlowers * dahlia);
                    }
                    break;

                   

                case  "Tulips":
                    if (numFlowers > 80)
                    {
                        totalPrice = (numFlowers * tulip) * 0.85;
                    }
                    else
                    {
                        totalPrice = (numFlowers * tulip);
                    }
                    break;


                case  "Narcissus":
                    if (numFlowers < 120)
                    {
                        totalPrice = numFlowers * (narcissus * 1.15);
                    }
                    else
                    {
                        totalPrice = numFlowers * narcissus;
                    }
                    break;


                case  "Gladiolus":
                    if (numFlowers < 80)
                    {
                        totalPrice = numFlowers * (2.50 * 1.20);
                    }
                    else
                    {
                        totalPrice = numFlowers * gladiolus;
                    }
                    break;
            }


            if (totalPrice <= budgete)
            {
                Console.WriteLine($"Hey, you have a great garden with {numFlowers} {flowers} and {budgete - totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalPrice - budgete:f2} leva more.");
            }
        }
    }
}
