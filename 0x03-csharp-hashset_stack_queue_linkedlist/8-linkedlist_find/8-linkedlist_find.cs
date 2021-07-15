using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int count = 0;
        for (var node = myLList.First; node != null; node = node.Next, count++)
        {
            if (value.Equals(node.Value))
                return count;
        }
        return -1;
    }
}
