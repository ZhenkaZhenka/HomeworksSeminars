// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// Не использовать строки для расчета.

// 456 -> 5
// 782 -> 8
// 918 -> 1


int Number(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool Validation(int a)
{
    if (a >= 100 && a <= 999) return true;
    else return false;
}

int number = Number("Введите трезначное число");

if (Validation(number)) Console.WriteLine($"Вторая цифра введенного числа {number % 100 / 10}");
else Console.WriteLine("Число не трехзначное");