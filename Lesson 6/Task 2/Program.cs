// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double ReadData(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

(double, double) GetCoordinate(double b1, double k1, double b2, double k2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = k2 * x + b2;
    return (x, y);
}

void Execute()
{
    double b1 = ReadData("Input coefficient B1");
    double k1 = ReadData("Input coefficient K1");
    double b2 = ReadData("Input coefficient B2");
    double k2 = ReadData("Input coefficient K2");
    Console.WriteLine($"With coefficients K1={k1}, B1={b1}, K2={k2}, B2={b2} point of intersection of straight lines will be {GetCoordinate(b1, k1, b2, k2)}");
}

Execute();