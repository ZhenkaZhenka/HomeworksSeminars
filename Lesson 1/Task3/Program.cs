// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число для последующей проверки на четность");

int number = Convert.ToInt32(Console.ReadLine()); //Вводим число из команной строки(Метод Convert.ToInt32() использую чтоб не проверять число на Null)

if (number % 2 == 0) Console.WriteLine("Число четное");
else Console.WriteLine("Число нечетное");
