using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        Dictionary<string, string> sortedDict = new Dictionary<string, string>();
        List<string> tempList = new List<string>();

        if (myDict.Count > 0)
        {
            foreach (var entry in myDict)
            {
                tempList.Add(entry.Key);
            }
            tempList.Sort();
            foreach (var key in tempList)
            {
                Console.WriteLine("{0}: {1}", key, myDict[key]);
            }
        }
    }
}
