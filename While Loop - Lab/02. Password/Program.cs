using System;

namespace _02._Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string pass = Console.ReadLine();

            string input= Console.ReadLine();
            while(input != pass)
            {
                
                input = Console.ReadLine();
            }
            if(pass == input)
            {
                Console.WriteLine($"Welcome {userName}!");
            }
























            //string username = Console.ReadLine();
            //string password = Console.ReadLine();

            //string input = Console.ReadLine();
            //while(input != password)
            //{
            //    input = Console.ReadLine();

            //}

            //Console.WriteLine($"Welcome {username}!");
        }
    }
}
