// Задача 3. (*) Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. 
//Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6??, 8-6=2

int ReadData(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int GetSumOfTheMaxValues(int[,] array)
{
    int sumOfMax = 0;
    PrintArray(array);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int maxInRow = array[i, 0];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > maxInRow) maxInRow = array[i, j];
            if (j == array.GetLength(1)-1) sumOfMax += maxInRow;
        }
    }
    Console.WriteLine(sumOfMax);
    return sumOfMax;
}

int GetSumOfTheMinValues(int[,] array)
{
    int sumOfMin = 0;
    PrintArray(array);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int minInRow = array[i, 0];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < minInRow) minInRow = array[i, j];
            if (j == array.GetLength(1)-1) sumOfMin += minInRow;
        }
    }
    Console.WriteLine(sumOfMin);
    return sumOfMin;
}

void Execute()
{
    int rowsInArray = ReadData("Input an amount of a rows in the array");
    int columnsInArray = ReadData("Input an amount of  columns in the array");
    int[,] arr = GetArray(rowsInArray, columnsInArray);
    PrintArray(arr);
    int sumOfMax = GetSumOfTheMaxValues(arr);
    int sumOfMin = GetSumOfTheMinValues(arr);
    int diff = sumOfMax - sumOfMin;
    Console.WriteLine($"A summ of max values in rows is {sumOfMax}, a summ of min values in rows is {sumOfMin}");
    Console.WriteLine($"Difference between a sum of max values in rows and a sum min values in rows is {diff}");
}

Execute();
