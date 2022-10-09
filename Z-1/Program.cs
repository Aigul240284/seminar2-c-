// Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8

Console.Clear();
Console.WriteLine("Введите трёхзначное число");
int num = int.Parse(Console.ReadLine() ?? "");
int a1 = num % 100;
int a2 = a1 / 10;

Console.WriteLine($"{num}->{a2}");