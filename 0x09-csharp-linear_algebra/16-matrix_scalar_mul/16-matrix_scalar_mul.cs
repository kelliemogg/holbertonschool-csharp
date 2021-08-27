using System;

class MatrixMath
{
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] not = {{ -1 }};
        double[,] newMatrix;
        double len1 = matrix.GetLength(0);
        double len2 = matrix.GetLength(1);
        int i, j = 0;

        /* first determine size of resulting matrix */
        if (len1 == 2 && len2 == 2)
        {
            newMatrix = new double[2, 2];
            for (i = 0; i < len1; i++)
            {
                for (j = 0; j < len2; j++)
                {
                    newMatrix[i, j] = matrix[i, j] * scalar;
                }
            }
            return newMatrix;
        }
        else if (len1 == 3 && len2 == 3)
        {
            newMatrix = new double[2, 2];
            for (i = 0; i < len1; i++)
            {
                for (j = 0; j < len2; j++)
                {
                    newMatrix[i, j] = matrix[i, j] * scalar;
                }
            }
            return newMatrix;
        }
        else
            return not;
    }
}
