// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int ReadData(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

double[,] CreateArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void FindArithmeticMean(double[,] array)
{
    double sumOfCol = 0;
    Console.Write("Arithmetic mean of the each column are: ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sumOfCol += array[i, j];// I chanched numOfColumn to n to at ease input
        }
        Console.Write($"{sumOfCol / array.GetLength(0)}\t");
    }
}

void Execute()
{
    int rowsInArray = ReadData("Input an amount of the rows in the array");
    int columnsInArray = ReadData("Input an amount of the columns in the array");
    double[,] arr = CreateArray(rowsInArray, columnsInArray);
    PrintArray(arr);
    FindArithmeticMean(arr);
}

Execute();