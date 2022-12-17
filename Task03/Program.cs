/*Напишите программу, которая будет выдавать
название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница
1. Введите номер дня недели (пн-1,вт-2,ср-3,чт-4,пт-5,сб-6,вс-7)
2. Выдает день недели*/

Console.Write("Введите номер дня недели (пн-1,вт-2,ср-3,чт-4,пт-5,сб-6,вс-7): ");
int number =Convert.ToInt32(Console.ReadLine());

if (number > 0 && number < 8)
{
    if (number == 1)
    {
        Console.Write("понедельник");
    }

    if (number == 2)
    {
        Console.Write("вторник");
    }

     if (number == 3)
    {
        Console.Write("среда");
    }

    if (number == 4)
    {
        Console.Write("четверг");
    }

     if (number == 5)
    {
        Console.Write("пятница");
    }

    if (number == 6)
    {
        Console.Write("суббота");
    }

        if (number == 7)
    {
        Console.Write("воскресенье");
    }
}
else
{
    Console.Write("нет такого дня недели");
}