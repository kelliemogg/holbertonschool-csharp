using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> nood = new LinkedListNode<int>(n);
        myLList.AddFirst(nood);
        return nood;
    }
}
