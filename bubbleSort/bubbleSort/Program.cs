using System;

namespace bubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 45, 32, 6, 1, 76 };

            for(int i = 0; i <= nums.Length-2; i++)
            {
                for(int j = 0; j <= nums.Length - 2; j++)
                {
                    if (nums[j] > nums[j+1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j+1];
                        nums[j+1] = temp;
                    }
                }
            }
            Console.WriteLine(" sorted array :" );

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(" " + nums[i]);
            }
        }
    }
}
