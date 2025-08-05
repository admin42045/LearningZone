using System.Collections.Generic;

namespace ArrayProblems
{
    internal class MoveZero
    {
        internal int[] MoveZeros(int[] nums)
            {
                var basket = new List<int>();
                foreach (int i in nums)
                {
                    if (i == 0)
                    {
                        basket.Add(i);
                    }
                }
                foreach (int i in nums)
                {
                    if (i != 0)
                    { basket.Add(i); }
                }
                return basket.ToArray();
            }
        }
}
