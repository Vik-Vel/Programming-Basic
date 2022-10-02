using System;

namespace _05._Game_Of_Intervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());

            double endResult = 0;
            double from0to9 = 0;
            double from10to19 = 0;
            double from20to29 = 0;
            double from30to39 = 0;
            double from40to50 = 0;
            double invailNum = 0;

            double points = 0;
            for(int i = 1; i <= people; i++)
            {
                points = int.Parse((Console.ReadLine()));   

                //endResult = endResult + points;

                if(points <= 0 && points <= 9)
                {
                    from0to9 = points * 0.8;
                }
                else if ( points <= 19)
                {
                    from10to19 = from10to19 + points;
                }
                else if (points <= 29)
                {
                    from20to29 = from20to29 + points;
                }
                else if (points <= 39)
                {
                    from30to39 = from30to39 + points;
                }
                else if (points <= 50)
                {
                    from40to50 = from40to50 + points;
                }
                else
                {
                    invailNum = invailNum + points;
                }

            }
            Console.WriteLine(endResult);




        }
    }
}
