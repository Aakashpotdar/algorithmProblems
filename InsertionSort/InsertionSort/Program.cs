using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[] { "yuvraj","rohit","virat","rahul","mahendra", "aakash" };
            int n = arr.Length, i, j, flag;
            string val;
            Console.WriteLine("Insertion Sort");
            Console.Write("Initial array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            for (i = 1; i < n; i++)
            {
                val = arr[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val.CompareTo( arr[j])<0)
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            Console.Write("\nSorted Array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
    
}
