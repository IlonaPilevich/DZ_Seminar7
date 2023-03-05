// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве и возвращает 
// значение этого элемента или же указание, что такого элемента нет

int[,] GetMatrix(int rows, int cols) // rows - кол-во строк, cols - кол-во столбцов
{
    int[,] matrix = new int[rows, cols]; // [строчка, столбец]
    for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) - строчка (rows)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  // matrix.GetLength(1) - столбец (cols)
        {
            matrix[i, j] = new Random().Next(1, 100);
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
Console.Write("Введите значение\nстроку, столбец: ");
string Numbers = Console.ReadLine();
int LookValue(string element, int[,] matrix)
{
    string[] array = element.Split(",");
    if (array.Length != 2)
    {
        Console.WriteLine("ОШИБКА");
    }
    int rows = Convert.ToInt32(array[0]);
    int cols = Convert.ToInt32(array[1]);
    if (cols > matrix.GetLength(0) || rows > matrix.GetLength(1))
    {
        Console.WriteLine($"Позиции {cols}, {rows} в матрице {matrix.GetLength(0)}, {matrix.GetLength(1)} не существует");
    } 
    return matrix[rows - 1, cols - 1];
}
int[,] matrix = GetMatrix(5, 5);
int Value = LookValue(Numbers, matrix);
Console.WriteLine("Исходная матрица:");
PrintMatrix(matrix);
Console.WriteLine($"Заданное значение: {Value}");