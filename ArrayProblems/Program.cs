using System;
using System.Collections.Generic;

namespace ArrayProblems
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int[] nums = { 1,2,3,4 };
            var obj = new ProductOfArray();
            var result = obj.ProductArrayOptimize(nums);
            foreach (var item in result)
                Console.Write(item +" ");

            Console.ReadKey();
        }


    }
}
