using System;

/// <summary> 
/// Vector Math 
/// </summary> 

class VectorMath
{
    /// <summary>
    /// Gets the sum of two vectors 
    /// </summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        Double lengthResult1 = vector1.Length;
        Double lengthResult2 = vector2.Length;

        if (lengthResult1 == 2 && lengthResult2 == 2)
        {
            double[] result2D = {0, 0};
            result2D[0] = vector1[0] + vector2[0];
            result2D[1] = vector1[1] + vector2[1];
            return result2D;
        }
        else if (lengthResult1 == 3 && lengthResult2 == 3)
        {
            double[] result3D = {0, 0, 0};
            result3D[0] = vector1[0] + vector2[0];
            result3D[1] = vector1[1] + vector2[1];
            result3D[2] = vector1[2] + vector2[2];
            return result3D;
        }
        else
            return -1;
    }
}
