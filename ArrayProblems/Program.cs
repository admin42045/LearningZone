using System;

namespace ArrayProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            int[] nums = { 0, 1, 0, 3, 12 };
            var objMove = new MoveZero();
            int[] result = objMove.MoveZeros(nums);
            foreach (int i in result) 
            {
                Console.Write($"{i} ");
            }
=======
            int[] nums = { 2,2,2,2,3,3,3,3,3};
            var objMove = new MajorityElement();
            int result = objMove.MajorityElements(nums);

            Console.Write($"{result} ");
            
>>>>>>> 76efa7da4ac29c6a592bb7a6abc984e8aa60af6c




            Console.ReadKey();
        }


    }
}
