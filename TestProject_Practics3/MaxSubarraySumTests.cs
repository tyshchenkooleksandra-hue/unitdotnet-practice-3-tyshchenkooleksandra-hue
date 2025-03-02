using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uni_DotNet_Practics3;

namespace TestProject_Practics3
{
    public class MaxSubarraySumTests
    {
        [Fact]
        public void FindMaxSum_ReturnsCorrectMaxSum()
        {
            var maxSubarraySum = new MaxSubarraySum();
            int[] nums = { -2, -3, 4, -1, -2, 1, 5, -3 };
            int result = maxSubarraySum.FindMaxSum(nums);
            Assert.Equal(7, result); // The max sum is 7 (subarray [4, -1, -2, 1, 5])
        }
    }
}
