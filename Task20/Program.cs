/*Задача 20: Напишите программу, которая
принимает на вход координаты двух точек и
находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21*/

Console.WriteLine("введите координаты первой точки:");
Console.Write("X: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int ay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координаты второй точки:");
Console.Write("X: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int by = Convert.ToInt32(Console.ReadLine());

double s = S(ax, ay, bx, by);
Console.WriteLine($"{s}");

double S(double x1, double y1, double x2, double y2)
{
    double lenghtx = x2 - x1;
    double lenghty = y2 - y1;
    double powx = Math.Pow(lenghtx, 2);
    double powy = Math.Pow(lenghty, 2);
    double sqrt = Math.Sqrt(powx + powy);
    double round = Math.Round(sqrt, 2, MidpointRounding.ToZero);
    return round;

}

/*Math.Pow(2, 2);
double d = Math.Sqrt(355);

double num = 5.099873456;
double numRound = Math.Round(num, 2, MidpointRounding.ToZero);
Console.WriteLine(numRound);*/
