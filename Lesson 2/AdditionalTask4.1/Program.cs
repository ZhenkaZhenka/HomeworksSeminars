// 4.1. Напишите программу, которая генерирует несколько случайных чисел, и в цикле проверяет, 
// кратны ли эти числа предварительно введенному числу, при кратности - цикл прерывается.
// Введенное число 2
// 13 -> нет 
// 15 -> нет 
// 12 -> да

int Number(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void MultiplicityChecking(int number)
{
    int randomNumber = new Random().Next();// This action makes random number
    while (randomNumber % number != 0)//here i'm checking a multiplicity
    {
        Console.WriteLine($"{randomNumber} is not a multiplу of {number}");
        randomNumber = new Random().Next();// This action makes new random number
    }
    Console.WriteLine($"{randomNumber} is a multiply of {number}");
}

MultiplicityChecking(Number("Input number for multiplicity checking"));