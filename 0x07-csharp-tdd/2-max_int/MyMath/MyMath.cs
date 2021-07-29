﻿using System;

namespace MyMath
{
    /// <summary> class Operations </summary>
    public class Operations
    {
        /// <summary> Find max int in a list </summary>
        public static int Max(List<int> nums)
        {
            int max, itr = 0;
            if (nums == null)
                return 0;
            for (itr = 0; itr <= nums.Count; itr++)
            {
                if (itr > max)
                {
                    max = itr;
                }
            }
            return max;
        }
    }
}