using System;
using System.Collections.Generic;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var sorted = new List<int> {1, 2, 3, 4, 5, 20, 30, 2352351, 1551346131};
            var unSorted = new List<int> {1, 1551346131, 3, 445, 5, 22340, 30, 2, 4, 2352351, 1234, 0, -12345, 23, 10};

            Console.WriteLine(IsSorted(sorted));
            Console.WriteLine(IsSorted(unSorted));

            unSorted = BubbleSort(unSorted);
            unSorted.ForEach(Console.WriteLine);
        }

        static bool IsSorted(List<int> nums)
        {
            var prev = Int32.MinValue;
            foreach (var num in nums)
            {
                if (prev > num)
                {
                    return false;
                }
                prev = num;
            }
            return true;
        }

        static List<int> BubbleSort(List<int> nums)
        {
            while (!IsSorted(nums))
            {
                var prev = Int32.MinValue;
                for (int i = 0; i < nums.Count; i++)
                {
                    if (prev > nums[i])
                    {
                        nums[i - 1] = nums[i];
                        nums[i] = prev;
                    }
                    prev = nums[i];
                }
            }
            return nums;
        }
    }
}