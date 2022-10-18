// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 
// Не использовать строки для расчета.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);

Console.WriteLine(number);//Output a random number for information

int GettingNewNumber(int number)
{
    int firstDigit = number / 100;
    int thirdDigit = number % 10;
    return firstDigit * 10 + thirdDigit;
}

Console.WriteLine($"After removing the second digit i got {GettingNewNumber(number)}");