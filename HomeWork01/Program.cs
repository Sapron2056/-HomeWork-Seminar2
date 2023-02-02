// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();

Console.WriteLine("Введите трехзначное число: ");
int A = int.Parse(Console.ReadLine()!);
int B = A % 100;
int C = B / 10;
Console.WriteLine(C);

