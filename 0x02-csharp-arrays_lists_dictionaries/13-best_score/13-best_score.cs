using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count > 0)
        {
            var result = myList.OrderByDescending(x => x.Value).First();
            return result.Key;
        }
        else
        {
            return "None";
        }
    }
}
