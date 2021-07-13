using System;
class Line
{
    public static void PrintLine(int length)
    {
        int a;
        if (length <= 0)
            Console.WriteLine("\n");
        for (a = 0; a < length; a++)
        {
            if (a == length)
                Console.WriteLine("\n");
            else
                Console.Write("_");
        }
    }
}
