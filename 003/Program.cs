// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

void FillMatrix(int[,] matrix, int min, int max)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(min, max);
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} ");
    Console.WriteLine();
    }
}

void NewMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                matrix[i, j] = matrix[i, j] * matrix[i, j];
            }
        }
    }
}

Console.WriteLine("Задайте количество строк ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Задайте количество столбцов ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[m, n];

Console.WriteLine("Заданная матрица");
FillMatrix(matrix, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Итоговая матрица");
NewMatrix(matrix);
PrintMatrix(matrix);