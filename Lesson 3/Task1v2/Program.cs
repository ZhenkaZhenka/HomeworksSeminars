// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

int number = Number("Input number you want to check on palindrome");
double counter = CalculationOfTheAmountOfDigits(number);
int newNumber = 0;
Console.WriteLine(counter);

int Number(string message)//input number
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

double CalculationOfTheAmountOfDigits(int number)//calculation of an amount of digits in number
{
    int amountOfDigits = 0;
    int temp = number;
    while (temp > 0)
    {
        temp = temp / 10;
        amountOfDigits++;
    }
    return amountOfDigits;
}

int ReverseOfNumber(int number, double counter)
{
    int numberNew = 0;
    int temp = 0;
    while (counter != 0)
    {
        temp = number % 10;
        numberNew = numberNew + temp*(int)Math.Pow(10.0, counter-1);
        number = number / 10;
        counter--;
    }
    return numberNew;
}

newNumber = ReverseOfNumber(number, counter);

if (number == newNumber & counter != 1) Console.WriteLine($"Number {number} is a palindrome");
else Console.WriteLine($"Number {number} is not a palindrome");