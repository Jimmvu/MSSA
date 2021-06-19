using System;

namespace leetcode
{
    class Program
    {
        static void Main()
        {
            int[] x = new int[] { 2, 3, 4};
            int y = 6;
            Console.WriteLine(TwoSum(x, y));
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = i+1; j < nums.GetLength(0); j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            throw new Exception("Not Found");
        }
    }
}
