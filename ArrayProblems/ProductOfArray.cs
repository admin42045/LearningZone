using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems
{
    public class ProductOfArray
    {
        public List<int>  ProductArray(int[] nums)
        {
            var ans = new List<int>();
            for (int i = 0; i<nums.Length; i++)
            {
                int product = 1;
                for(int j = 0; j<nums.Length; j++)
                {
                    if(i != j)
                    product *= nums[j];
                }
                ans.Add(product);
            }
            return ans;
        }
        public List<int> ProductArrayOptimize(int[] nums) 
        {

            int n = nums.Length;
            var result = new List<int>(new int[n]);

            result[0] = 1;
            for(int i = 1; i <n; i++)
            {
                result[i] = result[i - 1] * nums[i - 1];
            }

            int rightProduct = 1;
            for(int i = n-1; i >= 0; i--)
            {
                result[i] *= rightProduct;
                rightProduct *= nums[i];
            }
            
            return result;
        }
    }
}
