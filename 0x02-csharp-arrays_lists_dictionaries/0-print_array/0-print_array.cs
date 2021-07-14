using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        else
        {
            int[] array = new int[size];
            if (size == 0)
            {
                Console.WriteLine(""); 
                return array;
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = i;
                    Console.Write(i);
                    if (i < array.Length - 1)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
                return array;
            }
        }
    }
}
