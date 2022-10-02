using System;

namespace _01._Dishwasher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // дали закупеното количество ще стигне за всички чинии и тенджери?
            //1 чиния = 5мл. препарат, 1 тенджера = 15мл препарат, 1 препарат е 750мл. бутилка
            // на всяка трета съдомиялна се пълни само с тенджери
            // край когато получим "End" от конзолата 

            //променливи:
            int bottlePrep = int.Parse(Console.ReadLine());   //бутилки препарат
            string input = Console.ReadLine();   //вход
            int prepMil = bottlePrep * 750; //количество препарат
            int prepOut = 0; //изхабено количество
            int pots = 0;  //брой тенджери
            int plates = 0;  //брой чинии
            int counter = 1; //брояч на пътите
            

            while(input != "End")
            {
                int dishes = int.Parse(input);

                if (counter % 3 == 0)
                {
                    prepMil = prepMil - dishes * 15;
                    pots = pots + dishes;
                }
                else
                {
                    prepMil = prepMil - dishes * 5;
                    plates = plates + dishes;
                }



                if (prepMil < 0) 
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(prepMil)} ml. more necessary!");
                        break;

                }

                counter++;
                input = Console.ReadLine();
            }
            if(input == "End")
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{plates} dishes and {pots} pots were washed.");
                Console.WriteLine($"Leftover detergent {prepMil} ml.");

            }






        }
    }
}
