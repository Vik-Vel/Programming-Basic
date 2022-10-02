using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arrHour = int.Parse(Console.ReadLine());
            int arrMin = int.Parse(Console.ReadLine());

            //преобразуваме часовете в минути
            examMin = examHour * 60 + examMin;
            arrMin = examHour * 60 + arrMin;


            //намираме разликата във времето на пристигане
            int diffr = Math.Abs(examMin - arrMin);

            //преобразуваме разликата в мин и часове
            double hours = examMin / 60;
            double min = examMin % 60;


            //Проверявааме дали студентът закъснява

            if (examMin < arrMin)
            {
                Console.WriteLine($"Late");

                //проверяваме дали закъснява с повече от 1 час
                if (hours >= 1)
                {
                    //проверяваме дали минутите са по-малко от 10 => отпечатваме с водеща 0 
                    if (min < 10)
                    {
                        Console.WriteLine($"{hours}:0{min} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hours}:{min} hours after the start");
                    }
                }
                else
                {
                    Console.WriteLine($"{min} minutes after the start");
                }
            }
            //Проверявааме дали студентът e на време за изпита 
            else if (examMin - arrMin <= 30)
            {
                Console.WriteLine("On time");

                if (examMin != arrMin)
                {
                    Console.WriteLine($"{diffr} minutes before the start");

                }
            }
            //Проверявааме дали студентът e подранил за изпита 
            else
            {
                Console.WriteLine("Early");
                //проверяваме дали подранява с повече от 1 час
                if (hours >= 1)
                {
                    //проверяваме дали минутите са по-малко от 10 => отпечатваме с водеща 0 
                    if (min < 10)
                    {
                        Console.WriteLine($"{hours}:0{min} hours after the start");

                    }

                    else
                    {
                        Console.WriteLine($"{hours}:{min} hours before the start");
                    }
                }

                else
                {
                    Console.WriteLine($"{min} minutes before the start");
                }



            }
        }
    }
}
