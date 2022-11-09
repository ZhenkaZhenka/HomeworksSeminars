// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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

int GetAmountOfEvenNumbers(int[] array)
{
    int counter = 0;
    foreach (int item in array)
    {
        if (item % 2 == 0) counter++;
    }
    return counter;
}

PrintArray(array);
Console.WriteLine($"Amount of the even numbers in array is {GetAmountOfEvenNumbers(array)}");