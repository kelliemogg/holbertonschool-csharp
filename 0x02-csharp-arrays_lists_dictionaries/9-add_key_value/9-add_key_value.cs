using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        string val = "";
        if (myDict.TryGetValue(key, out val))
        {
            myDict[key] = val + value;
        }
        else
        {
            myDict.Add(key, value);
        }
        return myDict;
    }
}
