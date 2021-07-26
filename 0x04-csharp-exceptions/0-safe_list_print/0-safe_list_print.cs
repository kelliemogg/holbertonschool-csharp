using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int a = 0;
        while (a < n)
        {
            try
            {
                Console.WriteLine(myList[a]);
                a++;
            }
            catch (System.Exception)
            {
                return (a);
            }
        }
        return (n);
    }
}
