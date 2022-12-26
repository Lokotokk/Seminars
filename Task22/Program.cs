/*Задача 22: Напишите программу, которая
принимает на вход число (N) и выдаёт таблицу
квадратов чисел от 1 до N.*/

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0) Console.WriteLine("число не является натуральным");
else
{
    Table(number);
}
void Table(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count}  {Math.Pow(count, 2)}");
        count = count + 1;
    }

}