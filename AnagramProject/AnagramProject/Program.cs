using System;

namespace AnagramProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string 1");
            string name1 = Console.ReadLine();

            Console.WriteLine("enter the string 2");
            string name2 = Console.ReadLine();

            char[] data1 = name1.ToLower().ToCharArray();
            char[] data2 = name2.ToLower().ToCharArray();

            Array.Sort(data1);
            Array.Sort(data2);

            string Sname1 = new string(data1);
            string Sname2 = new string(data2);

            if (Sname1.Equals(Sname2))
            {
                Console.WriteLine("the strings are Anangram");
            }
            else
            {
                Console.WriteLine("the strings are not Anangram");
            }
        }
    }
}
