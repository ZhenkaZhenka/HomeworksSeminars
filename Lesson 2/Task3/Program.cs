// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета.

// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6

//Program works with any-digit numbers and any sequence number of digit

int Number(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = new Random().Next();
Console.WriteLine(number);
int numberOfDesiredDigit = Number("Input a desired sequence number of a digit");//Put number of the desired sequence number
int counter = 0;

bool Validation(int a)
{
    if (counter < 0) return true;//validator ready to check any sequence number of any digit;
    else return false;
}

int CalculationOfCounter(int counter, int desiredNumber)
{
    
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
    while (CalculationOfCounter(counter, numberOfDesiredDigit) > 0)
    {
        number = number / 10;//i'll devide untill get a three-digit number
        counter--;
    }
    return number % 10;//i get desired digit
}

int thirdDigit = GettingAThirdDigit(number);

if (Validation(counter))
{
    Console.WriteLine($"{numberOfDesiredDigit} digit of random number is {thirdDigit}");
}
else Console.WriteLine($"Number hasn't {numberOfDesiredDigit} digit");
