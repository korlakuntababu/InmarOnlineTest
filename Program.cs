
using System;
namespace ProgramingOnlineTest
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=100;i++)
            {
                if(i%3==0 && i%5==0)
                {
                    Console.WriteLine(i + " is dividable by 3 & 5 and output is fizzbuzz");
                }
                else if(i%3==0)
                {
                    Console.WriteLine(i + " is dividable by 3 and output is fizz");
                }
                else if(i%5==0)
                {
                    Console.WriteLine(i + " is dividable by 5 and output is buzz");
                }
            }

            Console.ReadLine();
        }
    }
}
