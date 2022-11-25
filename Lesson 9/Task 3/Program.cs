// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadData(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int AccermanFunc(int m, int n)
{
    if (m == 0 && n > 0) return n+1;
    if (m > 0 && n == 0) return AccermanFunc(m - 1, 1);
    return AccermanFunc(m - 1, AccermanFunc(m, n - 1));
}

int m = ReadData("input m");
int n = ReadData("input n");
Console.WriteLine(AccermanFunc(m, n));