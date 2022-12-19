/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да 
7 -> да 
1 -> нет
*/

Console.Write("Напишите цифру обозначающую день недели от 1 до 7: ");
int number = int.Parse(Console.ReadLine() ?? "");

if (number == 1)
{
    Console.WriteLine($"{number} ---> НЕТ");
}
else if (number == 2)
{
    Console.WriteLine($"{number} ---> НЕТ");
}
else if (number == 3)
{
    Console.WriteLine($"{number} ---> НЕТ");
}
else if (number == 4)
{
    Console.WriteLine($"{number} ---> НЕТ");
}
else if (number == 5)
{
    Console.WriteLine($"{number} ---> НЕТ");
}
else if (number == 6)
{
    Console.WriteLine($"{number} ---> ДА");
}
else if (number == 7)
{
    Console.WriteLine($"{number} ---> ДА");
}
else
    Console.WriteLine($"Число {number}, не является днем недели");