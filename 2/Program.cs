/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите любое целое число: ");
string userInput = Console.ReadLine() ?? "";
int number = int.Parse(userInput);
int a3 = 0;
while ((int)a3 = number % 10 / 1)
{
    Console.WriteLine($"{number} ---> {a3}");
    break;
    number = number % 10 / 1;
}


/* 
if (number >= 100 && number < 1000)
{
    int a3 = number % 10 / 1;
    Console.WriteLine($"{number} ---> {a3}");
}
else if (number >= 1000 && number < 10000)
{
    int a3 = number % 100 / 10;
    Console.WriteLine($"{number} ---> {a3}");
}
else if (number >= 10000 && number < 100000)
{
    int a3 = number % 1000 / 100;
    Console.WriteLine($"{number} ---> {a3}");
}
else if (number >= 100000 && number < 1000000)
{
    int a3 = number % 10000 / 1000;
    Console.WriteLine($"{number} ---> {a3}");
}
else if (number >= 1000000 && number < 10000000)
{
    int a3 = number % 100000 / 10000;
    Console.WriteLine($"{number} ---> {a3}");
}
else if (number >= 10000000 && number < 100000000)
{
    int a3 = number % 1000000 / 100000;
    Console.WriteLine($"{number} ---> {a3}");
}
else if (number >= 100000000 && number < 1000000000)
{
    int a3 = number % 10000000 / 1000000;
    Console.WriteLine($"{number} ---> {a3}");
}
else if (number < 100)
{
    Console.WriteLine($"{number} ---> третьей цифры нет");
} */