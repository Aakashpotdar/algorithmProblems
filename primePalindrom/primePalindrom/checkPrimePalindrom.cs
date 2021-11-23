using System;
using System.Collections.Generic;
using System.Text;

namespace primePalindrom
{
    class checkPrimePalindrom
    {
        public void check(int number)
        {
            int num = number;
            int rev = 0;
            while (number > 0)
            {
                int temp = number % 10;
                rev = (rev * 10) + temp;
                number = number / 10;
            }
            if (num == rev)
            {
                Console.WriteLine(num + " is prime and pelindrom ");
            }
        }
        public void opration()
        {
            Console.WriteLine("hi");
            int num = 1000;
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                count = 0;
                for (int j = 1; j < num ; j++)
                {
                    if ((i % j) == 0)
                    {
                        count++;

                    }
                }

                if (count == 2)
                {
                    //Console.Write(" " + i);
                    check(i);
                }
            }
        }
    }
}
