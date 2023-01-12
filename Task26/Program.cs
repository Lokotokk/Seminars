
/*Задача 26: Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/


Console.WriteLine("введите число:   ");
int number = Convert.ToInt32(Console.ReadLine());
int quantitydigit = QuantityDigit(number);
    Console.WriteLine($"{number} -> {quantitydigit}");

int QuantityDigit(int num)
{
    int i = 0;
    while (num > 0)
    {
        num = num / 10;
        i++;
    }
    return i;
}
