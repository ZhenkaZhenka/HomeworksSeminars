// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите 3 числа для сравнения");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c) Console.WriteLine($"{a} - наибольшее число из трех");
else if (b > a && b > c) Console.WriteLine($"{b} - наибольшее число из трех");
else Console.WriteLine($"{c} - наибольшее число из трех");