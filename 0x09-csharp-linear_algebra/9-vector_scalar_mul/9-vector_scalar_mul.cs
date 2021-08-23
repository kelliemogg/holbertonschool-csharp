using System;

class VectorMath
{
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] not = {-1};
        double lengthResult1 = vector.Length;

        if (lengthResult1 == 2)
        {
            double[] result2D = {0, 0};
            result2D[0] = vector[0] * scalar;
            result2D[1] = vector[1] * scalar;
            return result2D;
        }
        else if (lengthResult1 == 3)
        {
            double[] result3D = {0, 0, 0};
            result3D[0] = vector[0] * scalar;
            result3D[1] = vector[1] * scalar;
            result3D[2] = vector[2] * scalar;
            return result3D;
        }
        else
            return not;
    }
}

