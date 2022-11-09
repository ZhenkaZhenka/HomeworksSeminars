// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



double ax = Number("Input AX coordinate");
double ay = Number("Input AY coordinate");
double az = Number("Input AZ coordinate");
double bx = Number("Input BX coordinate");
double by = Number("Input BY coordinate");
double bz = Number("Input BZ coordinate");

double Number(string message)//input number
{
    Console.WriteLine(message);
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}


double diffX = Math.Pow(ax-bx, 2);//получение квадрата разности 
double diffY = Math.Pow(ay-by, 2);//получение квадрата разности 
double diffZ = Math.Pow(az-bz, 2);//получение квадрата разности 

double distance = Math.Sqrt(diffX+diffY+diffZ);
Console.WriteLine($"Distance between A and B is {distance:f2}");