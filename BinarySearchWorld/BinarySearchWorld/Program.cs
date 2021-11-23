using System;
using System.Collections;

namespace BinarySearchWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearch obj = new BinarySearch();
            Console.WriteLine("enter the limit of array:");
            int limit = int.Parse(Console.ReadLine());
            string[] name = new string[limit];
            for(int i = 0; i < limit; i++)
            {
                Console.WriteLine("enter data in array:");
                name[i] = Console.ReadLine();

            }

            obj.Search(name, "aakash");

        }
    }
}
