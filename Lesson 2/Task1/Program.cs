// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// Не использовать строки для расчета.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// !!!Вопрос: В методе Validator(), если я делаю условие (a < 100 && a > 999) это условие всегда является false, 
// я не разобрался почему, подскажете?


int Number(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool Validation(int a)
{
    if (a >= 100 && a <= 999) return true;//Is it a three-digit number?
    else return false;
}

int number = Number("Введите трезначное число");//Getting a number

if (Validation(number)) 
{
Console.WriteLine($"Вторая цифра введенного числа {number % 100 / 10}");//If Validation is true, we calculate second digit of the number
}
else 
{
Console.WriteLine("Число не трехзначное");
}