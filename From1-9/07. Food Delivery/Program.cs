using System;

namespace _07._Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberChicken = int.Parse(Console.ReadLine());
            int numberFish = int.Parse(Console.ReadLine());
            int numberVegetarian = int.Parse(Console.ReadLine());

            double chickenMenu = numberChicken * 10.35;
            double fishMenu = numberFish * 12.40;
            double vegetarianMenu = numberVegetarian * 8.15;
            double totalMenu = chickenMenu + fishMenu + vegetarianMenu;
            double dessert = totalMenu * 0.2;
            double delivery = 2.50;
            double totalOrder = totalMenu + dessert + delivery;

            Console.WriteLine(totalOrder);



         }
    }
}
