// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите два числа для сравнения");
int a = Convert.ToInt32(Console.ReadLine());//Введите число(Метод Convert.ToInt32() использую чтоб не проверять число на Null)
int b = Convert.ToInt32(Console.ReadLine());//Введите число(Метод Convert.ToInt32() использую чтоб не проверять число на Null)

if (a>b) Console.WriteLine($"max = {a}") ;//Сравниваем числа и выводим максимальное число
else Console.WriteLine($"max = {b}");