using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchWorld
{
    class BinarySearch
    {
        public void Search(string[] names,string name)
        {

            int value=Array.BinarySearch(names, "king");
            Console.WriteLine("the " + name + " is present at " + value);
        }
    }
}
