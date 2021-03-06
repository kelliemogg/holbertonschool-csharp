using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary> class Operations </summary>
    public class Operations
    {
        /// <summary> Find max int in a list </summary>
        public static int Max(List<int> nums)
        {
            int itr = 0;
            if (nums.Count == 0)
                return 0;
            int max = nums[0];
            for (itr = 0; itr < nums.Count; itr++)
            {
                if (nums[itr] > max)
                {
                    max = nums[itr];
                }
            }
            return max;
        }
    }
}
