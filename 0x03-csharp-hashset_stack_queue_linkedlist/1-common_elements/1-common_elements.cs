using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        HashSet<int> set1 = new HashSet<int>(list1);
        HashSet<int> set2 = new HashSet<int>(list2);
        HashSet<int> newHash = new HashSet<int>(set1);
        List<int> newList = new List<int>();

        newHash.IntersectWith(set2);
        foreach (int i in newHash)
            newList.Add(i);
        return newList;
    }
}
