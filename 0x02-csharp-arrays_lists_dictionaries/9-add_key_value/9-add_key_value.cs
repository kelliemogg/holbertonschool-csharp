using System;

class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        if (myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return -1;
        }
        int max_num = myList[0];
        foreach (int i in myList)
        {
            if (max_num < i)
                max_num = i;
        }
        return max_num;
    }
}
