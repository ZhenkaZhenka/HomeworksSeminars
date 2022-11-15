// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int ReadData(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GetArray (int length)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = ReadData("Input number to array");//new Random().Next(-10,10); - Use this comment to ease your checking
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach(int item in array)
    {
        Console.Write($"{item} ");
    }
}

int GetPositiveCount(int[] array)
{
    int counter = 0;
    foreach(int item in array)
    {
        if (item>0) counter++;
    }
    return counter;
}

void Execute()
{
    int[] array = GetArray(ReadData("Input size of the array"));
    PrintArray(array);
    Console.WriteLine($"Customer input {GetPositiveCount(array)} positive numbers");
}

Execute();