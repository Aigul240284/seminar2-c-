// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.Clear();
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine() ?? "");
int a1 = num;
if (a1 > 99)
{
    while (a1 >= 999)
        a1 = a1 / 10;
    int a2 = a1 % 10;
    Console.WriteLine($"{num}-> {a2}");
}
else  Console.WriteLine($"{num}-> третьей цифры нет"); 


