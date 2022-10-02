using System;

namespace _08.Cinema_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int hour = 0;

            switch(day)
            {
                case "Monday":
                    hour = 12;
                    break;

                case "Tuesday":
                    hour = 12;
                    break;

                case "Wednesday":
                    hour = 14;
                    break;

                case "Thursday":
                    hour = 14;
                    break;
                case "Friday":
                    hour = 12;
                    break;

                case "Saturday":
                    hour = 16;
                    break;

                case "Sunday":
                    hour = 16;
                    break;


            }
            Console.WriteLine(hour);

        }
    }
}
