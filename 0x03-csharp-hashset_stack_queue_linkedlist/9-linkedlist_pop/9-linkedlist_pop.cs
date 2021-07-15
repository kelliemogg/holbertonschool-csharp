using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        int val = 0;
        if (myLList.Count == 0)
            return 0;
        var node = myLList.First;
        val = node.Value;
        myLList.Remove(node);
        return val;
    }
}
