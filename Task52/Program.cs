// Задайте двумерный массив из целых чисел. Найдите средне арифметичкое элементов в каждом столбце

int[,] GetMatrix(int rows, int cols) // rows - кол-во строк, cols - кол-во столбцов
{
    int[,] matrix = new int[rows, cols]; // [строчка, столбец]
    for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) - строчка (rows)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  // matrix.GetLength(1) - столбец (cols)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix; // вернули заполненную таблицу
}
void PrintMatrix(int[,] matr)
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
int[] ValueElements(int[,] matrix)
{
    int[] value = new int[matrix.GetLength(1)];
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    for (int i = 0; i < cols; i++)
    {
        int sum = 0;
        for (int j = 0; j < rows; j++)
        {
            sum = sum + matrix[j, i];
        }
        value[i] = sum/rows;
    }
    return value;
}
Console.WriteLine("Исходный массив: ");
int[,] matrix = GetMatrix(3, 4);
PrintMatrix(matrix);
int[] value = ValueElements(matrix);
Console.WriteLine();
Console.WriteLine($"{string.Join("\t", value)} - средняя арифметическая всех столбцов");