// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Квадратные матрицы одинаковых размеров решает

int ReadData(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int CalculationResult(int[,] matrix1, int[,] matrix2, int i, int j)
{
    int arrBox = 0;
    int k = i;
    int m = j;
    for (int l = 0; l < matrix1.GetLength(0); l++)
    {
        arrBox += matrix1[k, l] * matrix2[l, m];
    }
    return arrBox;
}

int[,] MultiplyMatrixes3x3(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = CalculationResult(matrix1, matrix2, i, j);
        }
    }
    return result;
}

void Main()
{
    int m = ReadData("input an amount of the rows in matrixes");
    int n = ReadData("input an amount of the columns in matrixes");
    int[,] array1 = CreateArray(m, n);
    int[,] array2 = CreateArray(m, n);
    Console.WriteLine("Matrix 1 is:");
    PrintArray(array1);
    Console.WriteLine("Matrix 2 is:");
    PrintArray(array2);
    int[,] result = MultiplyMatrixes3x3(array1, array2);
    Console.WriteLine("The result of multiplying of matrix1 and matrix2 is:");
    PrintArray(result);
}

Main();



