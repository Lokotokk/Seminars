/*9. Напишите программу, которая выводит
случайное число из отрезка [10, 99] и показывает
наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8*/

int number = new Random().Next(10, 100); // получаем случайные числа из диапазона от 10 до 99
Console.WriteLine($"случайное число из отрезка 10 -99 =>{number}");

/*int firstDigit = number / 10;
int secondDigit = number % 10;*/

/*if(firstDigit>secondDigit) Console.WriteLine($"наибольшая цифра числа =>{firstDigit}");
else Console.WriteLine($"наибольшая цифра числа =>{secondDigit}");*/

/*int result = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.WriteLine($"наибольшая цифра числа => {result}");*/

int maxDigit = MaxDigit(number);
Console.WriteLine($"наибольшая цифра числа => {maxDigit}");

int maxDigit1 = MaxDigit(45);
Console.WriteLine($"наибольшая цифра числа => {maxDigit1}");

int maxDigit2 = MaxDigit(78);
Console.WriteLine($"наибольшая цифра числа => {maxDigit2}");

int MaxDigit(int num) // num = number
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;
}