// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

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
            Console.Write($"{array[i, j]:f2}\t");
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
            array[i, j] = new Random().Next(0, 10) + new Random().NextDouble();
        }
    }
    return array;
}

void FindElement(double[,] array, int index1, int index2)
{
    int rowsInArray = array.GetLength(0);
    int columnsInArray = array.GetLength(1);
    if ((index1 >= 0 && index1 <= rowsInArray) && (index2 >= 0 || index2 <= columnsInArray)) Console.WriteLine($"In array[{index1}, {index2}] attached {array[index1, index2]:f2}"); 
    else Console.WriteLine("This array doesn.t contain the input indexes");
}

void Execute()
{
    int rowsInArray = ReadData("Input an amount of the rows in the array");
    int columnsInArray = ReadData("Input an amount of the columns in the array");
    int index1 = ReadData("Input index of the row to find the number");
    int index2 = ReadData("Input index of the columns to find the number");
    double[,] arr = CreateArray(rowsInArray, columnsInArray);
    PrintArray(arr);
    FindElement(arr, index1, index2);
}

Execute();