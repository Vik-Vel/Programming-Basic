using System;

namespace DEMO
{
    class Program
    {
        static void Main(string[] args)
        {

            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            m = m + h * 60;

            int mAfter = m + 15;

            int hrsAfter = mAfter / 60;
            int minAfter = mAfter % 60;

            if (hrsAfter > 23)
            {
                hrsAfter = 0;

            }

            if(minAfter < 10)
            {
                Console.WriteLine($"{hrsAfter}:0{minAfter}");
            }

            else
            {
                Console.WriteLine($"{hrsAfter}:{minAfter}");

            }
        }
    }
}
