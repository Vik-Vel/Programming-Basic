using System;

namespace _04._Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "s3cr3t!P@ssw0rd";
            string passFromUser = Console.ReadLine();

           // bool isCorrectPassword = passFromUser == password;
           // if( isCorrectPassword)
            if( passFromUser == password)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
