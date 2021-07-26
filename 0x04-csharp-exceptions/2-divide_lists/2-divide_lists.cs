using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> results = new List<int>();
        int res = 0;
        int one = 0;
        for (one = 0; one < listLength; one++)
        {
            try
            {
                res = list1[one] / list2[one];
                results.Add(res);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                results.Add(0);
            }
            catch
            {
                Console.WriteLine("Out of range");
                results.Add(0);
            }
        }
        return (results);
    }
}
