using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> temp = new Dictionary<string, int>(myDict);
        foreach (var entry in myDict)
        {
            temp[entry.Key] = entry.Value * 2;
        }
        return temp;
    }
}
