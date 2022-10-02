using System;

namespace T01.HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int termOfDeposit = int.Parse(Console.ReadLine());
            double godishenLihvProcent = double.Parse(Console.ReadLine());

            double natrupanaLihva = deposit * 0.057;
            double lihvaZaMesec = natrupanaLihva / 12;
            double syma = deposit + termOfDeposit * (deposit * godishenLihvProcent);


            Console.WriteLine(syma);
           

        }
    }
}
