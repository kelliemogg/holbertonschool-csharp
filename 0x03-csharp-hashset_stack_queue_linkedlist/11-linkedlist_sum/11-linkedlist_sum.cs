using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int i = 0;
        foreach (int val in myLList)
        {
            i += val;
        }
        return i;
    }
}
