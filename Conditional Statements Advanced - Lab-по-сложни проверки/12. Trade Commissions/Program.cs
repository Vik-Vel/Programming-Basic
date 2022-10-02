using System;

namespace _12._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double obem = double.Parse(Console.ReadLine());

            double com = 0;
            if(city == "Sofia")
            {
                if( obem >= 0 && obem <= 500)
                {
                    com = obem * 0.05;
                }
                if (obem > 500 && obem <= 1000)
                {
                    com = obem * 0.07;
                }
                if (obem > 1000 && obem <= 10000)
                {
                    com = obem * 0.08;
                }
                if (obem > 10000)
                {
                    com = obem * 0.12;
                }              
            
            }
            if(city == "Varna")
            {
                if (obem >= 0 && obem <= 500)
                {
                    com = obem * 0.045;
                }
                if (obem > 500 && obem <= 1000)
                {
                    com = obem * 0.075;
                }
                if (obem > 1000 && obem <= 10000)
                {
                    com = obem * 0.10;
                }
                if (obem > 10000)
                {
                    com = obem * 0.13;
                }

            }

            if (city == "Plovdiv")
            {
                if (obem >= 0 && obem <= 500)
                {
                    com = obem * 0.055;
                }
                if (obem > 500 && obem <= 1000)
                {
                    com = obem * 0.08;
                }
                if (obem >1000 && obem <= 10000)
                {
                    com = obem * 0.12;
                }
                if (obem > 10000)
                {
                    com = obem * 0.145;
                }

            }

             if(com > 0)
            {
                Console.WriteLine($"{com:f2}");
            }


            else
            {
                Console.WriteLine("error");
            }

           


        }
    }
}
