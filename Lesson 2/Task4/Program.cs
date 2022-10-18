// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int Number(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

// int numberDayOfWeek = Number("Input number from 1 - 7 that means day of week");
// if (numberDayOfWeek > 7)
// {
//     Console.WriteLine("This is not a number of day of week");
// }
// else if (numberDayOfWeek > 5) 
// {
// Console.WriteLine("Input number matched to the weekend day");
// }
// else 
// {
// Console.WriteLine("Input number matched to the working day");
// }


switch (Number("Input number from 1 - 7 that means day of week"))
{
    case 1:
        Console.WriteLine("Monday - it's forst working day, sad");
        break;
    case 2:
        Console.WriteLine("Tuesday - second working day, 3 days left.");
        break;
    case 3:
        Console.WriteLine("Wednesday - meridian of working week,2 day left. Have you prepared plan on weekend?");
        break;
    case 4:
        Console.WriteLine("Thursday - 1 working day left");
        break;
    case 5:
        Console.WriteLine("Fraday - last working day, have you asked your boss to finish today earlier?");
        break;
    case 6:
        Console.WriteLine("Saturday - first weekend day");
        break;
    case 7:
        Console.WriteLine("Sunday - last weekend day");
        break;
    default:
        Console.WriteLine("This is not a number of the day of week");
        break;
}