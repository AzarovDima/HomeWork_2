/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8 
918 -> 1
 */

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine() ?? "");

int a1 = number / 10;
int a2 = a1 % 10;

if (number >= 100 && number < 1000)
{
    Console.WriteLine($"{number} --> {a2}");
}
else if (number > -1000 && number <= -100)
{
    Console.WriteLine($"{number} --> {a2}");
}
else
    Console.WriteLine("Вы ввели не трехзначное число");

