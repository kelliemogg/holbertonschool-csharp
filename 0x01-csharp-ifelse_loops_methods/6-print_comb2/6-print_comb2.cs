using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int f, s;
            for (f = 0; f < 9; f++)
            {
                for (s = f + 1; s <= 9; s++)
                {
                    if (f == s)
                        continue;
                    else if (f == 8 && s == 9)
                        Console.WriteLine("{0}{1}", f, s);
                    else
                        Console.Write("{0}{1}, ", f, s);
                }
            }
        }
    }
}
