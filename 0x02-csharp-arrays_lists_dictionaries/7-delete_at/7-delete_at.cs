using System;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
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
