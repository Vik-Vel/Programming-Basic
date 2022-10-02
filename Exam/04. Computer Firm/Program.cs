using System;

namespace _04._Computer_Firm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numComp = int.Parse(Console.ReadLine());

            double rating = 0;
            double sales = 0;
            double madeSales = 0;
            double averageRating = 0;
            double ratingAll = 0;


            for (int i = 1; i <= numComp; i++)
            {

                int input = int.Parse(Console.ReadLine());

                rating = input % 10;
                sales = input / 10;

              if(rating == 2)
                {
                    sales = 0;
                    ratingAll += rating;

                }

              else if(rating == 3)
                {
                    sales = sales * 0.5;
                    madeSales += sales;
                    ratingAll += rating;

                }

              else if(rating == 4)
                {
                    sales = sales * 0.7;
                    madeSales += sales;
                    ratingAll += rating;


                }

                else if(rating == 5)
                {
                    sales = sales * 0.85;
                    madeSales += sales;
                    ratingAll += rating;


                }

                else if(rating == 6 )
                {
                    sales = sales * 1;
                    madeSales += sales;
                    ratingAll += rating;


                }

            }
            Console.WriteLine($"{madeSales:f2}");
            Console.WriteLine($"{ratingAll/numComp:f2}");

        //Console.WriteLine(103/10);

    }
    }
}
