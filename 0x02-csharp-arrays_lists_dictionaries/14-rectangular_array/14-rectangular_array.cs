using System;

class Program
{
    static void Main(string[] args)
    {
        int w = 5;
        int h = 5;
        int[,] twod = new int[w, h];
        twod[2,2] = 1;

        for (int x = 0; x < w; x++)
        {
            for (int y = 0; y < h; y++)
            {
                if (y == h - 1)
                {
                    Console.Write (twod [x, y]);
                }
                else
                {
                    Console.Write (twod [x,y] + " ");
                }
            }
            Console.WriteLine ();
        }
    }
}
