using System;

namespace _02.Weekend_or_Working_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            string days = Console.ReadLine();



            if (days == "Monday" || days == "Tuesday" || days == "Wednesday" || days == "Thursday" || days == "Friday")
            {
                Console.WriteLine("Working day");
            }
            else if (days == "Saturday" || days == "Sunday")
            {
                Console.WriteLine("Weekend");
            }
            else
            {
                Console.WriteLine("Error");
            }

            //string day = Console.ReadLine();
            
            //switch (day)
            //{
            //    case "Monday":
            //    case "Tuesday":
            //    case "Wednesday":
            //    case "Thursday":
            //    case "Friday":

            //        Console.WriteLine("Working day");
            //        break;
            //    case "Saturday":
            //    case "Sunday":

            //        Console.WriteLine("Weekend");
            //        break;

            //    default:
            //        Console.WriteLine("Error");
            //        break;

            //}



        }
    }
}
