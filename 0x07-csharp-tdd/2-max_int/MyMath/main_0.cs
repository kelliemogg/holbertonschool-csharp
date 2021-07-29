using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() {1, 3, 4, 5, 7, 9};

            Console.WriteLine(MyMath.Operations.Max(nums));
        }
    }
}
