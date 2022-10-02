using System;

namespace _05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
           

            
            while(destination != "End")
            {
                double minBuget = double.Parse(Console.ReadLine());
                double allMoneySave = 0;
                while (allMoneySave < minBuget )
                {
                   
                    allMoneySave += double.Parse(Console.ReadLine());

                }
               
                  
                    Console.WriteLine($"Going to {destination}!");
              

             
                 destination = Console.ReadLine();
               
               
            }
            
































            //string destination = Console.ReadLine();




            //while(destination != "End")
            //{
            //    double budget = double.Parse(Console.ReadLine());
            //    double saveMoney = 0;
            //    while (saveMoney < budget)
            //    {
            //        saveMoney += double.Parse(Console.ReadLine());
            //    }
            //    Console.WriteLine($"Going to {destination}!");
            //    destination = Console.ReadLine();

            //}







        }
    }
}
