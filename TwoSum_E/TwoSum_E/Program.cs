using System;

namespace TwoSum_E
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            solution.TwoSum(new int[3] {3,2,4},6);
        }
    }

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] index = new int[2];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > target)
                    break;
                else
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            index[0] = i;
                            index[1] = j;
                        }
                    }
                }
            }
            return index;
        }
    }
}
