using System;

namespace ArrayProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2,2,2,2,3,3,3,3,3};
            var objMove = new MajorityElement();
            int result = objMove.MajorityElements(nums);

            Console.Write($"{result} ");
            




            Console.ReadKey();
        }


    }
}
