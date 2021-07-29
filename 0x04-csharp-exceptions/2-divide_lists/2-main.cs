using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> list1 = new List<int>() {10, 0, 4};
        List<int> list2 = new List<int>() {2, 4, 0};
        List<int> result;

        result = List.Divide(list1, list2, 3);

        foreach (int i in result)
            Console.WriteLine(i);
    }
}
