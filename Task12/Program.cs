/*12. Напишите программу, которая будет принимать на
вход два числа и выводить, является ли первое число
кратным второму. Если число 1 не кратно числу 2, то
программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно*/

/*int firstnumber = new Random().Next(10, 100);
int secondnumber = new Random().Next(1, 1000);*/


Console.WriteLine("введите первое число: ");
int firstnumber = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("введите второе число:");
int secondnumber = Convert.ToInt32(Console.ReadLine());

string multiple = Multiple(firstnumber, secondnumber);
Console.WriteLine(Multiple(firstnumber, secondnumber));

string Multiple(int firstnum, int secondnum)
{
        int del = firstnum % secondnum;
        string result = del == 0 ? "кратно" : $"не кратно, остаток = {del}";
        return result;
}

/*Console.WriteLine("Введите первое число");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberTwo = Convert.ToInt32(Console.ReadLine());
int res = Multiplicity(numberOne, numberTwo);
Console.WriteLine(res == 0 ? "Кратно" : $"не кратно, остаток от деления {res}");
//     Console.WriteLine("Кратно");
// }
// else
// {
//     Console.WriteLine($"Не кратно, остаток {div}");
// }

int Multiplicity(int numOne, int numTwo)
{
    return numOne % numTwo;
}
*/