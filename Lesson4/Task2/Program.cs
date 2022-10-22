// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int number = Number("Input number you want to count summ of digits");

int Number(string message)//input number
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SummOfDigits(int number)
{
    int summ = 0;
    while (number > 0)
    {
        summ = summ + number % 10;
        number = number / 10;
    }
    return summ;
}

int result = SummOfDigits(number);
Console.WriteLine($"Summ of digits in {number} is {result}");