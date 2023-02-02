// // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// // 645 -> 5

// // 78 -> третьей цифры нет

// // 32679 -> 6
// Console.clear();
Console.Clear();

Console.Write("ВВедите число : ");
int number = int.Parse(Console.ReadLine()!);

while (number > 999)
{
    number = number / 10;
}

int result = number % 10;
if (number < 99)
{
    Console.WriteLine($"Третьего номера нет"!);
}
else
{
    Console.WriteLine($"{result}"!);
}
