using System;

class MatrixMath
{
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double[,] not = {{ -1 }};
        double[,] newMatrix;
        double row1 = matrix1.GetLength(0);
        double col1 = matrix1.GetLength(1);
        double row2 = matrix2.GetLength(0);
        double col2 = matrix2.GetLength(1);
        int i, j, k = 0;

        if (matrix1.GetLength(1) == matrix2.GetLength(0))
        {
            newMatrix = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
            for (i = 0; i < col2; i++)
            {
                for (j = 0; j < col1; j++)
                {
                    for (k = 0; k < row2; k++)
                    {
                        newMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            return newMatrix;
        }
        else
            return not;
    }
}
