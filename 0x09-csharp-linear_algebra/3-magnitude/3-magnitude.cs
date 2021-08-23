using System;

/// <summary> Vector Math </summary> 

class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        Double lengthResult = vector.Length;
        if (lengthResult == 2)
        {
            double res2D = 0;
            double result2D = 0;

            result2D = ((vector[0] * vector[0]) + (vector[1] * vector[1]));
            res2D = Math.Sqrt(result2D);
            res2D = Math.Round(res2D, 2);
            return res2D;
        }
        else if (lengthResult == 3)
        {
            double res3D = 0;
            double result3D = 0;

            result3D = ((vector[0] * vector[0]) + (vector[1] * vector[1]) + (vector[2] * vector[2]));
            res3D = Math.Sqrt(result3D);
            res3D = Math.Round(res3D, 2);
            return res3D;
        }
        else
            return -1;
    }
}
