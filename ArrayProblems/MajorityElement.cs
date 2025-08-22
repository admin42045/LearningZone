using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ArrayProblems
{
    public class MajorityElement
    {
        public int MajorityElements(int[] nums)
        {
            int candidate = 0, count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(count == 0)
                {
                    count++;
                    candidate = nums[i];
                }
                else
                {
                    if (candidate == nums[i])
                        count++;
                    else
                        count--;
                }
            }
            return candidate;
        }
    }
}
