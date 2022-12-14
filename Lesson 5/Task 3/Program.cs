// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int Number(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[] GetArray(int lengthArray)
{
    double[] array = new double[lengthArray];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() + new Random().Next(0, 20);
    }
    return array;
}

double GetMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

double GetMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

void PrintArray(double[] array)
{
    foreach (double item in array)
    {
        Console.Write($"{item:f4} ");
    }
    Console.WriteLine();
}

double GetDifference(double min, double max) => max - min;

void Execute()
{
    int lengthArray = Number("Input size of an array");
    int topLimit = Number("Input a top limit of the random number in the array");
    int downLimit = Number("Input a down limit of the random number in the array");
    double[] array = GetArray(lengthArray);
    double min = GetMin(array);
    double max = GetMax(array);
    double diff = GetDifference(min, max);

    PrintArray(array);

    Console.WriteLine($"Minimal number in array is {min:f2}");
    Console.WriteLine($"Maximal number in array is {max:f2}");
    Console.WriteLine($"Difference between min and max numbers in array is {diff:f2}");
}

Execute();