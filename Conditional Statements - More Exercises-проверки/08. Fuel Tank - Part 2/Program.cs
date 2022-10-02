using System;

namespace _08._Fuel_Tank___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            double quanity = double.Parse(Console.ReadLine());
            string card = Console.ReadLine().ToLower();

            double gasoline = quanity * 2.22;
            double diesel = quanity * 2.33;
            double gas = quanity * 0.93;

            // CENA S OTSTUPKA S KARTA NA LITAR
            double gasolineOff = 2.22 - 0.18;
            double dieselOff = 2.33 - 0.12;
            double gasOff = 0.93 - 0.08;

            // CENA S OTSTUPKA S KARTA KRAINA
            double totalWhitCardGasoline = quanity * gasolineOff;
            double totalWhitCardDiesel = quanity * dieselOff;
            double totalWhitCardGas = quanity * gasOff;

            double result = 0;
            if (quanity > 25 )
            {
              
            }
            





        }
    }
}
