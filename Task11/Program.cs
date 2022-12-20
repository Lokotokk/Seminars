/*11. Напишите программу, которая выводит случайное
трёхзначное число и удаляет вторую цифру этого
числа.
456 -> 46
782 -> 72
918 -> 98*/

int number = new Random().Next(100, 1000);
Console.WriteLine($"случайное трехзначное число =>{number}");

int digit = Digit(number);
Console.WriteLine($"{number} => {digit}");
int Digit(int num) // num = number
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    int result = firstDigit * 10 + secondDigit;
    return result;
}
