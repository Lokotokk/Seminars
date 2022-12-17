//Напишите программу, которая 
//1.на вход принимает два числа
//2. проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да
//a = 2, b = 10 -> нет
//a = 9, b = -3 -> да
//a = -3 b = 9 -> нет

Console.WriteLine("введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2)
{
    Console.Write($"a = {number1},b = {number2} -> да");
}
else
{
    Console.Write($"a = {number1},b = {number2} -> нет");
}
