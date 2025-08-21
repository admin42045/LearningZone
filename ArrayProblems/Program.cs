using System;

namespace ArrayProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 0, 3, 12 };
            var objMove = new MoveZero();
            int[] result = objMove.MoveZeros(nums);
            foreach (int i in result) 
            {
                Console.Write($"{i} ");
            }




            Console.ReadKey();
        }


    }
}
