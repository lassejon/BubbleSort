using System;
using System.Collections.Generic;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var unSorted = new List<int> {1, 1551346131, 3, 445, 5, 22340, 30, 2, 4, 2352351, 1234, 0, -12345, 23, 10};

            var sorted = BubbleSort(unSorted);
            sorted.ForEach(Console.WriteLine);
        }

        // Optimized 
        static List<int> BubbleSort(List<int> nums)
        {
            var isSorted = false;
            var sortTo = nums.Count;
            while (!isSorted)
            {
                isSorted = true;
                var prev = int.MinValue;
                for (var i = 0; i < sortTo; i++)
                {
                    if (prev > nums[i])
                    {
                        (nums[i - 1], nums[i]) = (nums[i], prev);
                        isSorted = false;
                    }
                    prev = nums[i];
                }
                sortTo--;
            }
            return nums;
        }
    }
}