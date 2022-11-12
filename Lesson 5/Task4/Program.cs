// Задача 4 (*) При помощи рекурсии вывести последовательность чисел, с заданым количеством этих чисел по принципу:
// Ввожу => 12
// 1 2 2 3 3 3 4 4 4 4 5 5


int Number(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void NameOfMethod(int sizeOfRow, int startNumber)
{
    int varForCycle = startNumber;
    int varForWriting = startNumber;
    int lastSizeOfRow = sizeOfRow;
    while (varForCycle > 0)
    {
        Console.Write($"{varForWriting} ");
        --varForCycle;
        --lastSizeOfRow;
        if (lastSizeOfRow <= 0) break;
    }
    if (lastSizeOfRow > 0) NameOfMethod(lastSizeOfRow, startNumber + 1);
}

void Execute()
{
    int sizeOfRow = Number("Input a size of the row");
    int startNumber = Number("Number that you want to start the row");
    NameOfMethod(sizeOfRow, startNumber);
}

Execute();