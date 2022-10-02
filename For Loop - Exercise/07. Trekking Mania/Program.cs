using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());

            double sumAllAlpins = 0;
            double Musala = 0;
            double Monblan = 0;
            double Khilimanjaro = 0;
            double K2 = 0;
            double Everest = 0;

            for (int i = 1; i <= groups; i++)
            {
                double numOfAlpinsIn1Group = int.Parse(Console.ReadLine());

                sumAllAlpins += numOfAlpinsIn1Group;

                if (numOfAlpinsIn1Group <= 5)
                    Musala += numOfAlpinsIn1Group;

                else if (numOfAlpinsIn1Group <= 12)
                    Monblan += numOfAlpinsIn1Group;

                else if (numOfAlpinsIn1Group <= 25)
                    Khilimanjaro += numOfAlpinsIn1Group;

                else if (numOfAlpinsIn1Group <= 40)
                    K2 += numOfAlpinsIn1Group;

                else
                    Everest += numOfAlpinsIn1Group;


            }
            Musala = Musala / sumAllAlpins * 100.00;
            Monblan = Monblan / sumAllAlpins * 100.00;
            Khilimanjaro = Khilimanjaro / sumAllAlpins * 100.00;
            K2 = K2 / sumAllAlpins * 100.00;
            Everest = Everest / sumAllAlpins * 100.00;

            Console.WriteLine($"{Musala:f2}%");
            Console.WriteLine($"{Monblan:f2}%");
            Console.WriteLine($"{Khilimanjaro:f2}%");
            Console.WriteLine($"{K2:f2}%");
            Console.WriteLine($"{Everest:f2}%");


        }
    }
}
