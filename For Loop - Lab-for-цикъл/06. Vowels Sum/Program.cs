using System;

namespace _06._Vowels_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string word = Console.ReadLine();

            int lenghtOfWord = word.Length;

            int sum = 0;

            for(int i = 0; i < lenghtOfWord; i++)
            {
                char currentLetter = word[i];

                switch(currentLetter)
                {
                    case 'a':
                        //sum++;
                        sum=sum+1;
                        break;

                    case 'e':
                        //sum += 2;
                        sum=sum+2;
                        break;

                    case 'i':
                        //sum += 3;
                        sum=sum+3;
                        break;

                    case 'o':
                        sum=sum+4;
                      //  sum+= 4;
                        break;

                    case 'u':
                        sum=sum+5;  
                       //sum += 5;
                        break;

                }
                
            }
            Console.WriteLine(sum);


        }
    }
}
