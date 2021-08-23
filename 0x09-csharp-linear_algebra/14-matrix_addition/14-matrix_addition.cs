using System;
/// <summary>
/// Vector Math
/// </summary>

class MatrixMath
{
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double not = -1;
        double lengthResult1 = matrix1.GetLength;
        double lengthResult2 = matrix2.GetLength;

        if (lengthResult1 == 2 && lengthResult2 == 2)
        {
            double result2D = 0;
            result2D[0][0] = matrix1[0][0] + matrix2[0][0];
            result2D[0][1] = matrix1[0][1] + matrix2[0][1];
            result2D[1][0] = matrix1[1][0] + matrix2[1][0];
            result2D[1][1] = matrix1[1][1] + matrix2[1][1];
            return result2D;
        }
        else if (lengthResult1 == 3 && lengthResult2 == 3)
        {
            double result3D = 0;
            result2D[0][0] = matrix1[0][0] + matrix2[0][0];
            result2D[0][1] = matrix1[0][1] + matrix2[0][1];
            result2D[0][2] = matrix1[0][2] + matrix2[0][2];
            result2D[1][0] = matrix1[1][0] + matrix2[1][0];
            result2D[1][1] = matrix1[1][1] + matrix2[1][1];
            result2D[1][2] = matrix1[1][2] + matrix2[1][2];
            result2D[2][0] = matrix1[2][0] + matrix2[2][0];
            result2D[2][1] = matrix1[2][1] + matrix2[2][1];
            result2D[2][2] = matrix1[2][2] + matrix2[2][2];
            return result3D;
        }
        else
            return not;
    }
}
