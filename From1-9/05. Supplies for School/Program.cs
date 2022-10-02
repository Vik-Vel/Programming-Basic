using System;

namespace _05._Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            int broiPaketiHimikali = int.Parse(Console.ReadLine());
            int broiPaketiMarkeri = int.Parse(Console.ReadLine());
            int litriPreparat = int.Parse(Console.ReadLine());
            int otstupka = int.Parse(Console.ReadLine());

            double cenaPaketiHimikali = broiPaketiHimikali * 5.80;
            double cenaPaketiMarkeri = broiPaketiMarkeri * 7.20;
            double cenaPreparat = litriPreparat * 1.20;
            double cenaNaVsichkiMateriali = cenaPaketiHimikali + cenaPaketiMarkeri + cenaPreparat;
            double otstupkaVProcenti = otstupka * 0.01;
            double otstupkaProbvam = (cenaNaVsichkiMateriali * otstupkaVProcenti);
            double cenaSNamalenie = cenaNaVsichkiMateriali - otstupkaProbvam ;

            Console.WriteLine(cenaSNamalenie);





        }
    }
}
