using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShakhovDK.Sprint6.Task7.V7.Lib
{
    public class DataService : ISprint6Task7V7
    {
        public int[,] GetMatrix(string path)
        {
            // Читаем строки из файла
            string[] lines = File.ReadAllLines(path);

            // Определяем размеры матрицы
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            // Создаём двумерный массив
            int[,] matrix = new int[rows, columns];

            // Заполняем массив данными из файла
            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');

                for (int j = 0; j < columns; j++)
                {
                    if (int.TryParse(values[j], out int value))
                    {
                        matrix[i, j] = value;
                    }
                    else
                    {
                        throw new FormatException($"Не удалось преобразовать значение \"{values[j]}\" в целое число.");
                    }
                }
            }

            // Проверяем, есть ли пятая строка и заменяем нечётные значения на 66
            if (rows >= 5)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[4, j] % 2 != 0)
                    {
                        matrix[4, j] = 66;
                    }
                }
            }

            return matrix;
        }
    }
}
