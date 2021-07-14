using System;

class Array
{
    public static int elementAt(int[] array, int index)
    {
        if (index > array.Length || index < 0)
        {
            Console.WriteLine("Index out of range");
            return -1;
        }
        else
        {
            for (int i = 0; i <= array.Length; i++)
            {
                if (i == index)
                    return array[i];
            }
            return -1;
        }
    }
}
