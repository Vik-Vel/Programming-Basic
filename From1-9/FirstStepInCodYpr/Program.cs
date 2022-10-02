using System;

namespace FirstStepInCodYpr
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int termOfDeposit = int.Parse(Console.ReadLine());
            double godishenLihvProcent = double.Parse(Console.ReadLine());

            double godishenLihvProcentt = godishenLihvProcent / 100;
            double natrupanaLihva = deposit * godishenLihvProcentt;
            double lihvaZaMesec = natrupanaLihva / 12;
            double syma = deposit + (termOfDeposit * lihvaZaMesec) ;


            Console.WriteLine(syma);

        }
    }
}
