using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> nood = myLList.First;

        for (; nood != null; nood = nood.Next)
        {
            if (nood.Value > n)
            {
                myLList.AddBefore(nood, n);
                return nood;
            }
        }
        myLList.AddLast(n);
        return nood;
    }
}
