using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        for (int i = 0; i < myList.Count; i++)
        {
            try
            {
                if (n < myList.Count)
                {
                    Console.WriteLine(i);
                }
                return (i);
            }
            catch (System.Exception)
            {
                foreach (int val in myList)
                {
                    Console.WriteLine(val);
                }
            }
        }
        return (n);
    }
}
