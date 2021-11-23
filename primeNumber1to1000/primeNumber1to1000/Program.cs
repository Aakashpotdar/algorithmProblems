using System;

namespace primeNumber1to1000
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("the prime numbers present in 1 to 1000 : ");
            for(int i = 1; i <= 1000; i++)
            {
                int num = 0;
                int count = 0;
                for(int j = 1; j <= i/2; j++)
                {
                    num = i % j;
                    if(num==0)
                    count++;
                }
                if (count == 1)
                {
                    Console.Write(" "+i);
                }
                count = 0;

            }
        }
    }
}
