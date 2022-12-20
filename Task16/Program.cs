﻿/*16. Напишите программу, которая 
принимает на вход два числа и 
проверяет, является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет*/

Console.WriteLine("введите первое число: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Square(firstnumber, secondnumber) ? "да" : "нет");

bool Square(int num1, int num2)
{
    return num1 == num2 * num2 || num2 == num1 * num1;
}