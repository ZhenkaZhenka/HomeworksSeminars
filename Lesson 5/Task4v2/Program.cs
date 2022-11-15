// Задача 4 (*) При помощи рекурсии вывести последовательность чисел, с заданым количеством
// этих чисел по принципу:
// Ввожу => 12
// 1 2 2 3 3 3 4 4 4 4 5 5
int ReqSeq(int n)
{
    int sum = 0;
    int j = 0;
    if (n == 1)
    {
        Console.Write(1);
        return 0;
    }
    else
    {
        for (int i = 1; sum < n; i++)
        {
            sum += i;
            j = i;
        }
        Console.Write(ReqSeq(--n) + 0 + j);
        return 0;
    }
}

int s = ReqSeq(15);
