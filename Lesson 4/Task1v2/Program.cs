// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
//рекурсией

int numberA = Number("Input number you want to multiply");
int numberB = Number("Input number what will be power");

int Number(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Multiplicity (int number, int power)
{
    if (power == 0) return 1;
    if (power == 1) return number;
    return number * Multiplicity(number, power - 1);
}

int raisedNumber = Multiplicity(numberA, numberB);
Console.WriteLine($"{raisedNumber} is a raised {numberA} to a power {numberB} ");
