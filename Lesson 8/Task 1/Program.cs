// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] SortOfTheArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int counter = 1;
        while (counter != 0)
        {
            counter = 0;
            for (int j = 0; j < array.GetLength(1)-1; j++)
            {
                if(array[i,j] < array[i,j+1])
                {
                    (array[i,j], array[i,j+1]) = (array[i,j+1],array[i,j]);
                    counter++;
                }
            }
        }
    }
    return array;
}

void Main()
{
    int m = ReadData("Input rows");
    int n = ReadData("input columns");
    int[,] array = CreateArray(m,n);
    PrintArray(array);
    array = SortOfTheArray(array);
    PrintArray(array);
}

Main();