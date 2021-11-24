using System;
using System.Collections.Generic;
using System.Text;

namespace FindMyNumber
{
    public class Search
    {
        public void searchNumber(int limit)
        {
            int first = 1;
            int last = limit - 1;
            int mid = (first + last) / 2;
            bool a =true;
            while (a)
            {
                Console.WriteLine("the number is " + mid + " then press 'k', press 'l' for number is less than, press'g'for grater than number");
                char key = char.Parse(Console.ReadLine());
                switch (key)
                {
                    case 'k':
                        a = false;
                        break;
                    case 'l':
                        last = mid - 1;
                        mid = (first + last) / 2;
                        break;
                    case 'g':
                        first = mid + 1;
                        mid = (first + last) / 2;
                        break;
                }
            }
        }
    }
}
