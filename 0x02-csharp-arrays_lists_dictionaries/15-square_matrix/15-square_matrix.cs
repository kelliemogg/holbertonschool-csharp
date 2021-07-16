using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int [,] squared = myMatrix;
        int rows = myMatrix.GetLength(0);
        int cols = myMatrix.GetLength(1);

        for (int x = 0; x < rows; x++)
        {
            for (int y = 0; y < cols; y++)
            {
                myMatrix[x, y] *= myMatrix[x, y];
            }
        }
        return squared;
    }
}
