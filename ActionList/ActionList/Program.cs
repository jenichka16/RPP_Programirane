using System;
using System.Collections.Generic;
using System.Linq;

namespace ActionList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int last = nums{nums.Count - 1};
            int last1 = nums.Last();
            nums.RemoveAll(x => x == last);
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
