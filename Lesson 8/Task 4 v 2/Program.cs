// Задача 4. (*) Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Работает корректно только  с массивом 4х4


int ReadData(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(string[,] array)
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

void MoveRight(string[,] array, int k, int l, int number, int step)
{
    for (; l < array.GetLength(1) - step; l++)
    {
        array[k, l] = number.ToString("D2");
        number++;
    }
    MoveDown(array, k + 1, l - 1, number, step);
}

void MoveDown(string[,] array, int k, int l, int number, int step)
{
    for (; k < array.GetLength(0) - step; k++)
    {
        array[k, l] = number.ToString("D2");
        number++;
    }
    MoveLeft(array, k - 1, l - 1, number, step);
}

void MoveLeft(string[,] array, int k, int l, int number, int step)
{
    for (; l > 0 + step; l--)
    {
        array[k, l] = number.ToString("D2");
        number++;
    }
    MoveUp(array, k, l, number, step);
}

void MoveUp(string[,] array, int k, int l, int number, int step)
{
    for (; k > 0 + step; k--)
    {
        array[k, l] = number.ToString("D2");
        number++;
    }
    if (step + 1 < array.GetLength(0) / 2)
    {
        step++;
        MoveRight(array, k + step, l + step, number, step);
    }
}

void FillingArray(string[,] array, int number, int i, int j, int step)
{
    int k = i; //Start position
    int l = j; //Start position
    MoveRight(array, k + step, l + step, number, step);
}

void Main()
{
    int m = ReadData("rows");
    int n = ReadData("columns");
    int number = ReadData("Input start number"); // Start number
    int step = 0;
    string[,] array = new string[m, n];
    FillingArray(array, number, 0, 0, step);
    PrintArray(array);
}

Main();