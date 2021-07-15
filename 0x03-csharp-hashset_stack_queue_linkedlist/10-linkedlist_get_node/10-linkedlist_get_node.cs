using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        var node = 0;
        if (myLList.Count == 0)
            return 0;
        foreach (int val in myLList)
        {
            if (node == n)
                return val;
            node ++;
        }
        return 0;
    }
}

