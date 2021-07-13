using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int c = 0; c <= 98; c++)
                Console.WriteLine("{0} = 0x{0:x}", c);
        }
    }
}
