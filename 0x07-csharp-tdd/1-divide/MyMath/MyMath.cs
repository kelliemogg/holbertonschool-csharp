using System;

namespace MyMath
{
    /// <summary> class Matrix </summary>
    public class Matrix
    {
        /// <summary> Divides elements of a matrix by num </summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            int a, b = 0;
            int array1 = matrix.GetLength(0);
            int array2 = matrix.GetLength(1);
            int [,] newMatrix = new int[array1, array2];
            if (matrix == null)
            {
                return null;
            }
            try
            {
                for (a = 0; a < array1; a++)
                {
                    for (b = 0; b < array2; b++)
                    {
                        newMatrix = matrix[a, b] /= num;
                    }
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
            return newMatrix;
        }
    }
}
