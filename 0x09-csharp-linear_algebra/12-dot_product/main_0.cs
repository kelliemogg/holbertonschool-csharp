using System;

class Program
{
    static void Main(string[] args)
    {
        double[] vector1 = { 7, 11 };
        double[] vector2 = { -3, 2 };

        Console.WriteLine(VectorMath.DotProduct(vector1, vector2));
    }
}
