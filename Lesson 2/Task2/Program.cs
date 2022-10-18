// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 
// Не использовать строки для расчета.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);

Console.WriteLine(number);//Output a random number for information
Console.WriteLine($"{number/100}{number%10}");// by the {number / 100} i got first digit, by the {number % 10} i got third number.