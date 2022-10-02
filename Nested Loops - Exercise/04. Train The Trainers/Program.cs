using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numJudge = int.Parse(Console.ReadLine());
            string  nameOfPresentation = Console.ReadLine();


            double allPresentationRating = 0; //сборът на всички оценки на моментната презентация

            int presentationNum = 0; //броя на всички презентации;
            double rating = 0; //сбор от средните оценки за всяка от презентациите

            while (nameOfPresentation != "Finish")
            {

                for(int i = 1; i <= numJudge; i++)
                {
                    allPresentationRating += double.Parse(Console.ReadLine());
                }

                allPresentationRating = allPresentationRating / numJudge;

                rating += allPresentationRating;

                Console.WriteLine($"{nameOfPresentation} - {allPresentationRating:f2}.");

                presentationNum++;  

                nameOfPresentation = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {rating/presentationNum:f2}.");



        }
    }
}
