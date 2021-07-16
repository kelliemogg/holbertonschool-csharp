using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> nood = myLList.First;
        for (int i = 0; i <= index && nood != null; i++)
        {
            if (i != index)
            {
                nood = nood.Next;
                continue;
            }
            myLList.Remove(nood);
        }
    }
}
