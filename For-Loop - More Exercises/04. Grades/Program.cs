using System;

namespace _04._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfStudent = int.Parse(Console.ReadLine());

            double averageRating = 0;
            double fail = 0;
            double between3and399 = 0;
            double between4and499 = 0;
            double top = 0;
            double allRating = 0;
            double rating = 0;

            for(int i = 1; i <= numOfStudent; i++)
            {
                 rating = double.Parse(Console.ReadLine());

                allRating = allRating + rating;

                if (rating >= 5.00)
                {
                    top++;
                }
                else if (rating >= 4.00)
                {
                    between4and499++;

                }
                else if (rating >= 3.00)
                {
                    between3and399++;
                }
                else
                {
                    fail++;
                }
            }

            averageRating = allRating / numOfStudent;

            Console.WriteLine($"Top students: {(top/numOfStudent)*100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(between4and499/numOfStudent)*100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(between3and399/numOfStudent)*100:f2}%");
            Console.WriteLine($"Fail: {(fail/numOfStudent)*100:f2}%");
            Console.WriteLine($"Average: {averageRating:f2}");





        }
    }
}
