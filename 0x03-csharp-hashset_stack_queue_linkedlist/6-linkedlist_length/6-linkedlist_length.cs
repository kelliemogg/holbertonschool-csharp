using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int i = 0;
        for (int itr = 0; itr < myLList.Count; itr++)
        {
            i += 1;
        }
        return i;
    }
}
