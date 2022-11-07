// Показать двумерный массив размером m×n заполненный вещественными числами

void PrintArray(int[,] arr)
{
  for(int i = 0; i < arr.GetLength(0); i++)
{
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write($"{arr[i,j]}");
    }
Console.WriteLine();
}  
}

void FillArray(int[,] arr)
{
 for(int i = 0; i < arr.GetLength(0); i++)
{
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i,j] = new Random().Next(1,10);
    }   
}
}
// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
 int[] FindIndex(int[,] arr, int number)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == number)
                return new int[2] { i, j }; 
        }
    return new int[2] { -1, -1 };
}

//В матрице чисел найти сумму элементов главной диагонали
int SumDiagonal(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            if (i == j) 
                sum += arr[i, j];
    return sum;
}
//Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

double [] Sum(int[,] arr)
{
    double[] result = new double[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
            result[j] += arr[i, j];
        result[j] /= arr.GetLength(0);
    }
    return result;
}

// Написать программу, которая обменивает элементы первой строки и последней строки
int[,] ChangeFirstAndLast(int[,] arr)
{
    
    int temp = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        temp = arr[0, i];
        arr[0, i] = arr[arr.GetLength(0) - 1, i];
        arr[arr.GetLength(0) - 1, i] = temp;
    }
    return arr;
}

//В прямоугольной матрице найти строку с наименьшей суммой элементов.
int Min(int[,] arr)
{
    int minSum = 0;
    int minStroke = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
            sum += arr[i, j];

        if (sum < minSum||i==0)
        {
            minSum = sum;
            minStroke = i;
        }
    }
    return minStroke;
}

Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] array = new int[m,n];
FillArray(array);
PrintArray(array);

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
var index = FindIndex(array, number);
Console.WriteLine($"позиция числа {index[0]},{index[1]}");
Console.WriteLine($"Сумма элементов главной диагонали: {SumDiagonal(array)}");
var avereageArray = Sum(array);
foreach(var avereage in avereageArray)
Console.Write(avereage+ "\t");
Console.WriteLine();
PrintArray(ChangeFirstAndLast(array));
Console.WriteLine($" минималная строка {Min(array)}");

