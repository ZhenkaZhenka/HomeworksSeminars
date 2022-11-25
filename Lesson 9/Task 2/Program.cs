// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int ReadData(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfTheNaturalRow(int m, int n)
{
    if (m > n) return 0;
    return m + SumOfTheNaturalRow(m+1, n);

}

int m = ReadData("input M");
int n = ReadData("input N > M");
Console.WriteLine($"Sum of the natural elements in the row from {m} to {n} is {SumOfTheNaturalRow(m,n)}");
