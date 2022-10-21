// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Number(string message)//input number
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = Number("Input number");

//Решение через массив, но оно громоздкое
// int[] array = new int[number];
// array = SquareOfNumbers(number);

// int[] SquareOfNumbers(int number)
// {
//     for(int i=0; i < number; i++)
//     {
//         int temp = i + 1;
//         array[i] = temp * temp * temp;
//     }
//     return array;
// }

// for(int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i]);
//     if (i < array.Length - 1) Console.Write(", ");
// }

for(int i = 1; i <= number; i++)
{
    Console.Write(Math.Pow(i, 3));
    if (i < number) Console.Write(", ");
}