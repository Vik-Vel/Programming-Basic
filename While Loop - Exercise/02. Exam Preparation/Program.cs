using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int unsatisfRat = int.Parse(Console.ReadLine());

            string nameOfTask = Console.ReadLine();
            

            int numOfProb = 0;
            int numUnsatisfRat = 0;
            int numAllRating = 0;
            double allRating = 0;
            double averageRat = 0;
            string lastProbl = " ";

            while(nameOfTask != "Enough")
            {
                double ratingOfTask = double.Parse(Console.ReadLine());
                numAllRating++;
                allRating += ratingOfTask;
                lastProbl = nameOfTask;
                numOfProb++;

                if (ratingOfTask <= 4)
                {
                    numUnsatisfRat++;

                    if (numUnsatisfRat == unsatisfRat)
                    {
                       
                        Console.WriteLine($"You need a break, {numUnsatisfRat} poor grades.");
                        break;
                    }
                }

               
                

                nameOfTask = Console.ReadLine();
             

            }
            if(nameOfTask == "Enough")
            {

                Console.WriteLine($"Average score: {allRating / numAllRating:f2}");
                Console.WriteLine($"Number of problems: {numOfProb}");
                Console.WriteLine($"Last problem: {lastProbl}");


            }



















            //int failedTimes = int.Parse(Console.ReadLine());

            //double evaluationSum = 0; //сбор на вс оценки
            //int evaluationCount = 0; //брой на вс оценки
            //string lastExercise = ""; //име на последна/текуща задача 
            //int evaluation; // оценка от текуща задача 
            //int failedCount = 0; //брой оценки <=4, който е получил

            //string input = Console.ReadLine();

            //while (input != "Enough")
            //{
            //    lastExercise = input;
            //    evaluation = int.Parse(Console.ReadLine());

            //    evaluationSum += evaluation;
            //    evaluationCount++;

            //    if (evaluation <= 4)
            //    {
            //        failedCount++;

            //        if (failedCount == failedTimes)
            //        {
            //            Console.WriteLine($"You need a break, {failedCount} poor grades.");
            //            break;
            //        }
            //    }

            //    input = Console.ReadLine();
            //}

            //if (failedCount != failedTimes)
            //{
            //    double evaluationAverage = evaluationSum / evaluationCount;
            //    Console.WriteLine($"Average score: {evaluationAverage:F2}");
            //    Console.WriteLine($"Number of problems: {evaluationCount}");
            //    Console.WriteLine($"Last problem: {lastExercise}");
            //}

        }
    }
}
