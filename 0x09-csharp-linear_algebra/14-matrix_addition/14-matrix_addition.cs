using System;
using System.Collections.Generic;

/// <summary>
/// Vector Math
/// </summary>

class MatrixMath
{
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] not = {{ -1 }};
        double[,] newMatrix;
        double len1 = matrix1.GetLength(0);
        double len2 = matrix1.GetLength(1);
        double seclen1 = matrix2.GetLength(0);
        double seclen2 = matrix2.GetLength(1);
        int i, j = 0;

        /* first determine size of resulting matrix */
        if (len1 == 2 && len2 == 2 && seclen1 == 2 && seclen2 == 2)
        {
            newMatrix = new double[2, 2];
            for (i = 0; i < len1; i++)
            {
                for (j = 0; j < len2; j++)
                {
                    newMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return newMatrix;
        }
        else if (len1 == 3 && len2 == 3 && seclen1 == 3 && seclen2 == 3)
        {
            newMatrix = new double[2, 2];
            for (i = 0; i < len1; i++)
            {
                for (j = 0; j < len2; j++)
                {
                    newMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return newMatrix;
        }
        else
            return not;
    }
}


// using System;
// using System.Collections.Generic;

// /// <summary>
// /// Vector Math
// /// </summary>

// class MatrixMath
// {
//     public static double[,] Add(double[,] matrix1, double[,] matrix2)
//     {
//         double[,] not = {{ -1 }};
//         double lengthResult1 = matrix1.GetLength(0);
//         double lengthResult2 = matrix2.GetLength(0);

//         if (lengthResult1 == 2 && lengthResult2 == 2)
//         {
//             double[,] result2D = {{ 0 }};
//             result2D[0, 0] = matrix1[0, 0] + matrix2[0, 0];
//             result2D[0, 1] = matrix1[0, 1] + matrix2[0, 1];
//             result2D[1, 0] = matrix1[1, 0] + matrix2[1, 0];
//             result2D[1, 1] = matrix1[1, 1] + matrix2[1, 1];
//             return result2D;
//         }
//         else if (lengthResult1 == 3 && lengthResult2 == 3)
//         {
//             double[,] result3D = {{ 0 }};
//             result3D[0, 0] = matrix1[0, 0] + matrix2[0, 0];
//             result3D[0, 1] = matrix1[0, 1] + matrix2[0, 1];
//             result3D[0, 2] = matrix1[0, 2] + matrix2[0, 2];
//             result3D[1, 0] = matrix1[1, 0] + matrix2[1, 0];
//             result3D[1, 1] = matrix1[1, 1] + matrix2[1, 1];
//             result3D[1, 2] = matrix1[1, 2] + matrix2[1, 2];
//             result3D[2, 0] = matrix1[2, 0] + matrix2[2, 0];
//             result3D[2, 1] = matrix1[2, 1] + matrix2[2, 1];
//             result3D[2, 2] = matrix1[2, 2] + matrix2[2, 2];
//             return result3D;
//         }
//         else
//             return not;
//     }
// }
