using System;

namespace _02._Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());

            int doctors = 7;
            int pacientYes = 0;
            int pacientNo = 0;

            for (int i = 1; i <= period; i++)
            {
                if (i % 3 == 0)
                {
                    if (pacientNo > pacientYes)
                    {
                        doctors++;
                    }
                }

                int pacientFor1Day = int.Parse(Console.ReadLine());

                if (doctors < pacientFor1Day)
                {
                    pacientYes += doctors;
                    pacientNo += pacientFor1Day-doctors;
                }
                else
                {
                    pacientYes += pacientFor1Day;
                }

            }
            Console.WriteLine($"Treated patients: {pacientYes}.");
            Console.WriteLine($"Untreated patients: {pacientNo}.");




        }
    }
}
