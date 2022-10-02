using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double rating = double.Parse(Console.ReadLine());

            double allrating = 0;
            int grades = 1;
            int fails = 0;
            double average = 0;

            while(grades <= 12)
            {
                if (rating < 4)
                {
                    fails++;
                }

                if(fails == 2)
                {
                    grades--;
                    Console.WriteLine($"{name} has been excluded at {grades} grade");
                    break;
                }
                allrating += rating;             
                average = allrating / grades;
                grades++;
                if (grades>12)
                {
                    Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
                }
                    rating = double.Parse(Console.ReadLine());
            }





















            //string name = Console.ReadLine();
            //double rating = double.Parse(Console.ReadLine());
            //int counter = 1;
            //int countFails = 0;
            //double all = 0;
            //double average =0;

            //while(counter <= 12)
            //{
            //    if(rating < 4)
            //    {
            //        countFails++;
            //    }  
            //    if (countFails == 2) 
            //    {
            //        counter--;
            //        Console.WriteLine($"{name} has been excluded at {counter} grade");
            //        break;
            //    }
            //    all += rating;
            //    average = all / counter;
            //    counter++;
            //    if (counter > 12)
            //    {
                    
            //        Console.WriteLine($"{name} graduated. Average grade: {all / 12:f2}");
            //        break;
                
            //    }


            //    rating = double.Parse(Console.ReadLine());

            //}




            //string name = Console.ReadLine();

            //double rating = double.Parse(Console.ReadLine());
            //double totalRating = 0;
            //double averageRating = 0;
            //int currClassNumber = 1;
            //int fails = 0;

            //while (currClassNumber <= 12)
            //{
            //    if (rating < 4.00)
            //    {
            //        fails++;
            //    }
            //    if (fails == 2)
            //    {
            //        currClassNumber--;
            //        Console.WriteLine($"{name} has been excluded at {currClassNumber} grade");
            //        break;
            //    }

            //    totalRating = totalRating + rating;
            //    averageRating = totalRating / currClassNumber;
            //    currClassNumber++;

            //    if (currClassNumber > 12) 
            //    {
            //        Console.WriteLine($"{name} graduated. Average grade: {averageRating:f2}");
            //        break;
            //    }
            //    rating = double.Parse(Console.ReadLine());


            //}


        }
    }
}
