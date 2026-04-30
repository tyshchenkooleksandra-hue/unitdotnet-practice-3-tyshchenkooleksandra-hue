using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni_DotNet_Practics3
{
    public class MaxSubarraySum
    {
        public int FindMaxSum(int[] nums)
        {
            int maxSum = nums[0];
            int currentSum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                currentSum = Math.Max(nums[i], currentSum + nums[i]);
                maxSum = Math.Max(maxSum, currentSum);
            }

            return maxSum;
        }
    }

}
