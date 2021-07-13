using System;
class Line
{
    public static void PrintDiagonal(int length)
    {
        int x, y;
        if (length <= 0)
            Console.WriteLine("\n");
        for (x = 0; x < length; x++)
        {
            for (y = 0; y < x + 1; y++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("\\");
        }
    }
}
