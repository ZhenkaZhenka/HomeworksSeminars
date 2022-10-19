// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

//This program can check any number for the state of palindrome. Number restricted by the size of the integer


int number = Number("Input a number that you want to check for the state of the palindrome");
int amountOfDigits = 0;//amountOfDigits needed for checking an amount of the digits in the number
int counter = 0;


int Number(string message)//input number
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int CalculationOfTheAmountOfDigits(int number)//calculation of an amount of digits in number
{
    int temp = number;
    while (temp > 0)
    {
        temp = temp / 10;
        amountOfDigits++;
    }
    return amountOfDigits;
}

amountOfDigits = CalculationOfTheAmountOfDigits(number);//amountOfDigits needed for checking an amount of the digits in the number
int[] numbers = new int[amountOfDigits];

int[] NumberToArray(int number, int amountOfDigits)//transformation of integer number to array
{
    while (amountOfDigits > 0)
    {
        numbers[amountOfDigits - 1] = number % 10;
        number = number / 10;
        amountOfDigits--;
    }
    return numbers;
}

numbers = NumberToArray(number, amountOfDigits);//make global variable for numbers array

bool CheckingForParityOfANumber(int amountOfDigits)//Checking for parity of number
{
    if (amountOfDigits % 2 == 0) return true;
    else return false;
}

int CounterForEvenNumber(int[] numbers, int counter)//Calculation of a equal digits in number in the even number
{
    int arrLength = numbers.Length;
    for (int i = 0; (arrLength - (1 + i)) - i > 0; i++)
    {
        int indexOfLast = arrLength - (1 + i);//Index ondex of a second compared number from array
        if (numbers[i] == numbers[indexOfLast])
        {
            counter++;
        }
    }
    return counter;
}

int CounterForTheOddNumber(int[] numbers, int counter)//Calculation of a equal digits in number in the odd number
{
    int arrLength = numbers.Length;
    for (int i = 0; (arrLength - (1 + i)) - i >= 2; i++)
    {
        int indexOfLast = arrLength - (1 + i);//Index ondex of a second compared number from array
        if (numbers[i] == numbers[indexOfLast])
        {
            counter++;
        }
    }
    return counter;
}

bool CheckingTheEvenNumberForThePalindrome(int counter, int amountOfDigits)// Проверка на полиндром четное число
{
    if (CounterForEvenNumber(numbers, counter) == amountOfDigits) return true;
    else return false;
}

bool CheckingTheOddNumberForThePalindrome(int counter, int amountOfDigits)// проверка на полиндром нечетное число
{
    if (CounterForTheOddNumber(numbers, counter) == amountOfDigits - 1) return true;
    else return false;
}

if (CheckingForParityOfANumber(amountOfDigits))
{
    if (CheckingTheEvenNumberForThePalindrome(CounterForEvenNumber(numbers, counter), amountOfDigits))
    {
        Console.WriteLine($"The even number {number} is a palindrome");
    }
    else
    {
        Console.WriteLine($"The even number {number} is not a palidrome");
    }
}
else if (!(CheckingTheOddNumberForThePalindrome(CounterForTheOddNumber(numbers, counter), amountOfDigits)) || amountOfDigits == 1)
{
    Console.WriteLine($"The odd number {number} is not a palindrome");
}
else
{
    Console.WriteLine($"The odd number {number} is a palidrome");
}
