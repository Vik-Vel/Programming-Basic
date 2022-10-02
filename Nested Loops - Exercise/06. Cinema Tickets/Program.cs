using System;

namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine();

            int students = 0;
            int standard = 0;
            int kid = 0;

            while(filmName != "Finish")
            {
                int free = int.Parse(Console.ReadLine());

                string type = Console.ReadLine();

                int ticket = 0;

                while (type != "End")
                {
                    if (type == "student")
                    {
                        students++;
                        
                    }
                    else if(type == "standard")
                    {
                        standard++;
                       
                    }
                    else
                    {
                        kid++;
                        
                    }
                    ticket++;

                    if(ticket == free)
                    {
                        break;
                    }

                    type = Console.ReadLine();
                    
                }

                double occupancy = ticket * 100.00 / free;

                Console.WriteLine($"{filmName} - {occupancy:f2}% full.");

                filmName = Console.ReadLine();


            }
            int totalTickets = students + standard + kid;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(students * 100.00 / totalTickets):F2}% student tickets.");
            Console.WriteLine($"{(standard * 100.00 / totalTickets):F2}% standard tickets.");
            Console.WriteLine($"{(kid * 100.00 / totalTickets):F2}% kids tickets.");
        }
    }
}

