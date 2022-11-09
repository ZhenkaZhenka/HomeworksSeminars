// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int lengthArr = Number("Input a length of array");
int downLimit = Number("Input a down limit of numbers in array");
int topLimit = Number("Input a top limit of array");

int Number(string message)//input number
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] GetArray(int lengthOfArray, int downLimit, int topLimit)
{
    int[] array = new int[lengthOfArray];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(downLimit, topLimit);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
}

int[] array = GetArray(lengthArr, downLimit, topLimit);

int GetSummOfNumbers(int[] array)
{
    int summ = 0;
    for(int i = 1; i <= array.Length; i += 2)
    {
        summ += array[i];
    }
    return summ;
}

int summ = GetSummOfNumbers(array);

PrintArray(array);
Console.WriteLine($"Summ of the numbers that are in the odd position of the array is {summ}");