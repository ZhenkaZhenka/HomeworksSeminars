// Задача 4. (*) Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Решение не работает при m % 2 == 0 && n % 2 != 0 и работает до массива 8х8. Сложно


int ReadData(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
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

void MoveRight(int[,] array, int k, int l, int number, int step)
{
    for (; l < array.GetLength(1) - step; l++)
    {
        array[k, l] = number;
        number++;
    }
    MoveDown(array, k + 1, l - 1, number, step);
}

void MoveDown(int[,] array, int k, int l, int number, int step)
{
    for (; k < array.GetLength(0) - step; k++)
    {
        array[k, l] = number;
        number++;
    }
    MoveLeft(array, k - 1, l - 1, number, step);
}

void MoveLeft(int[,] array, int k, int l, int number, int step)
{
    for (; l > 0 + step; l--)
    {
        array[k, l] = number;
        number++;
    }
    MoveUp(array, k, l, number, step);
}

void MoveUp(int[,] array, int k, int l, int number, int step)
{
    for (; k > 0 + step; k--)
    {
        array[k, l] = number;
        number++;
    }
}

int[,] StepRoundArray(int[,] array, int i, int j, int step)
{
    int k = i; //Start position
    int l = j; //Start position
    int number;
    if (step <= array.GetLength(0) / 2)
    {
        //if (step % 2 == 0 || step > 3) number = array[k + step, l + step] + 1; // Ужасная формула, понимаю, получил "тупым" подбором. Просто прибавлять step- не работает почему-то ((int)(Math.Round((double)step / 2)))
        number = array[k + step, l] + 1;
        MoveRight(array, k + step, l + step, number, step);
        k++;
        l++;
        StepRoundArray(array, k, l, (step + 1));
    }
    return array;
}

void Main()
{
    int m = ReadData("Input an amount of the rows in array");
    int n = ReadData("Input an amount of the columns in array");
    int i = 0; // Start position index1
    int j = 0; // Start position index2
    int step = 0; // A necessary variable for recurtion
    int[,] array = new int[m, n];
    array = StepRoundArray(array, i, j, step);
    PrintArray(array);
}

Main();