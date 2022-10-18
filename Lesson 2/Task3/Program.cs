// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета.

// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6

int number = new Random().Next();
int counter = 0;
Console.WriteLine(number);

bool Validation(int a)
{
    if (a > 99) return true;//Is number has three-digit?
    else return false;
}

int CalculationOfCounter(int counter)
{
    int numberOfDesiredDigit = 3;//Put number of the desired sequence number
    int temp = number;                  
    while (temp > 0)
    {
        temp = temp / 10;
        counter++;
    }
    return counter - numberOfDesiredDigit;
}

int GettingAThirdDigit(int number)
{
    while (CalculationOfCounter(counter) > 0)
    {
        number = number / 10;//i'll devide untill get a three-digit number
        counter--;
    }
    return number % 10;//i get desired digit
}

int thirdDigit = GettingAThirdDigit(number);

if (Validation(number))
{
    Console.WriteLine($"Third digit of random number is {thirdDigit}");
}
else Console.WriteLine("Number hasn't third digit");
