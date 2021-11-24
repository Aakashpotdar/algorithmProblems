using System;

namespace FindMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Search obj = new Search();
            Console.WriteLine("enter the number for limit");
            int n = int.Parse(Console.ReadLine());
            obj.searchNumber(n);
        }
    }
}
