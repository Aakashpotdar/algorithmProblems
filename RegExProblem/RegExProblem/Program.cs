using System;

namespace RegExProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            changeData obj = new changeData();
            string lines = "Hello aakash,we have your full name as Aakash potdar in our system.Please,your contact number is 91-7387302460.Please let us know in any type of clerification thankyou BridgeLabz 01/01/2016";

            Console.WriteLine(lines);

            Console.WriteLine("In case you want to edit data type y or press n");

            char key = char.Parse(Console.ReadLine());

            if (key == 'y')
            {
                obj.EditData();
            }

        }
    }
}
