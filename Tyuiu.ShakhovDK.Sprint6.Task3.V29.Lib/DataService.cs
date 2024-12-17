using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShakhovDK.Sprint6.Task3.V29.Lib
{
    public class DataService : ISprint6Task3V29
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            int[,] res_matrix =  new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    res_matrix[i, j] = matrix[i, j];
                }
            }
            int[] columnArray = new int[columns];

            for (int i = 0; i < rows; i++)
            {
                columnArray[i] = matrix[i, 4];
            }
            Array.Sort(columnArray);

            for (int i = 0; i < rows; i++)
            {
                res_matrix[i, 4] = columnArray[i];
            }

            return res_matrix;
        }
        
    }
}
