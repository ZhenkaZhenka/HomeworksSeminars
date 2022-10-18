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

int temp = number;                  //I wanted to put 17-22 lines in the method, but in return i got permanent counter = 0
while (temp > 0)
{
    temp = temp / 10;
    counter = ++counter;
}

int GettingAThirdDigit(int number)
{
    while (counter - 3 > 0)//digit 3 is the sequence number of desired digit
    {
        number = number / 10;//i'll devide untill get a three-digit number
        counter = --counter;
    }
    return number % 10;//i get desired digit
}

int thirdDigit = GettingAThirdDigit(number);

if (Validation(number))
{
    Console.WriteLine($"Third digit of random number is {thirdDigit}");
}
else Console.WriteLine("Number hasn't third digit");
