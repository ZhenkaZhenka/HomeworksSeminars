// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

int FindSumInTheRow(int[,] array, int i)
{
    int sumInRow = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumInRow += array[i, j];
    }
    return sumInRow;
}

int NumberOfRow(int[,] array)
{
    int index = 0;
    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        if (FindSumInTheRow(array, i) > FindSumInTheRow(array, i + 1)) index = i + 1;
    }
    return index;
}

void Main()
{
    int m = ReadData("Input an amount of the rows in the array");
    int n = ReadData("Input an amount of the columns in the array");
    int[,] array = CreateArray(m, n);
    PrintArray(array);
    int indexMinSum = NumberOfRow(array) + 1; // I've done it to show number of the row but not a index;
    Console.WriteLine($"Number of the row with the minimal summ is {indexMinSum}");
}

Main();