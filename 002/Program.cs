// Задать двумерный массив следующим правилом: Aₘₙ = m+n

void FillA(int[,] A)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
            A[i, j] = i + j;
    }
}

void PrintA(int[,] A)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
            Console.Write($"{A[i, j]} ");
        Console.WriteLine();
    }
}

Console.WriteLine("Задайте количество строк ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Задайте количество столбцов ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] A = new int[m, n];

FillA(A);
PrintA(A);
