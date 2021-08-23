using System;

class Program
{
    static void Main(string[] args)
    {
        double[] vector = { 0, 6 };
        double[] result;

        result = VectorMath.Multiply(vector, 9);

        Console.WriteLine("(" + result[0] + ", " + result[1] + ")");
        // Console.WriteLine("(" + result[0] + ", " + result[1] + ", " + result[2] + ")");
        // Console.WriteLine("(" + result[0] + ")");
    }
}
