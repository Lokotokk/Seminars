/*17. Напишите программу, которая 
принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и 
выдаёт номер четверти плоскости, в которой находится эта точка.*/

Console.Writeline("введите координаты точки:");
Console.Write("X: ");
int x = Convert.ToInt32(Console.Readline());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.Readline());

int quater = Quater(x, y);
string result = quater > 0 
                ? $"Указанные координаты соотвествуют четверти -> {quater}"
                :"Введены некорректные координаты";
Console.Writeline(result);                  

int Quater(int xc, int yc);
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;
}

