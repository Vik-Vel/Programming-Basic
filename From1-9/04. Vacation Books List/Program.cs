using System;

namespace _04._Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int broiStr = int.Parse(Console.ReadLine());
            int strZaEdinChas = int.Parse(Console.ReadLine());
            int broiDni = int.Parse(Console.ReadLine());

            int obshtoVremeZaChetene = broiStr / strZaEdinChas;
            int neobhodimiChasoveNaDen = obshtoVremeZaChetene / broiDni;
            
            
          
            Console.WriteLine(neobhodimiChasoveNaDen);
        }
    }
}
