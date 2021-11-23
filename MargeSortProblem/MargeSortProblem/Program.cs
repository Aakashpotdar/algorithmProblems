using System;

namespace MargeSortProblem
{
    class Program
    {
        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        public static void Main(String[] args)
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            Console.WriteLine("Given Array");
            printArray(arr);
            MergeSort obj = new MergeSort();
            obj.sort(arr, 0, arr.Length - 1);
            Console.WriteLine("\nSorted array");
            printArray(arr);
        }
    }

}

