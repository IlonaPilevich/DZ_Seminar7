// Задайте двумерный массив размером m*n, заполненный случайными вещественными числами. m = 3, n = 4

double[,] GetMatrix(int rows, int cols, int minValue, int maxValue) // rows - кол-во строк, cols - кол-во столбцов
{
    double[,] matrix = new double[rows, cols]; // [строчка, столбец]
    for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) - строчка (rows)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  // matrix.GetLength(1) - столбец (cols)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble(), 2);
        }
    }
    return matrix; // вернули заполненную таблицу
}
void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
double[,] resultMatrix = GetMatrix(3, 4, 0, 10);   // 3 строчки, 4 столбца, числа от 0 до 10.
PrintMatrix(resultMatrix);