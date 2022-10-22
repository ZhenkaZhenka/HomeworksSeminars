// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int lengthOfArray = Number("Input array length that you want to see");
int[] array = new int[lengthOfArray];

int Number(string message)//input number
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] GetArray(int lengthOfArray)
{
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

array = GetArray(lengthOfArray);

for(int i = 0; i < array.Length; i++)
{
    if (i == 0) Console.Write("[");
    Console.Write(array[i]);
    if (i != array.Length - 1) Console.Write(", ");
    if (i == array.Length - 1) Console.Write("]");
}