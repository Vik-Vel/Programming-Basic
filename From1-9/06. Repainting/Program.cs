 using System;

namespace _06._Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double sumNylon = (nylon + 2) * 1.50;
            double sumPaint = ((paint * 0.1)+paint) * 14.50;
            double sumThiner = thinner * 5;
            double bag = 0.40;
            double totalSumForMaterials = sumNylon + sumPaint + sumThiner + bag;
            double sumForМaster = (totalSumForMaterials * 0.3) * hours;
            double totalSum = totalSumForMaterials + sumForМaster;

            Console.WriteLine(totalSum);
            





        }
    }
}
