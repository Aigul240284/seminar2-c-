// Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.Clear();
double varA;

while (true)
{
        Console.Write("Введите число от 1 до 7: ");
        if (double.TryParse(Console.ReadLine(), out varA))
              break;
        Console.WriteLine("Ошибка ввода!");
}
if(varA == 6 || varA == 7) Console.WriteLine($"{varA} -> да");

else 
{
    if(varA <= 0 || varA > 7) Console.WriteLine("Необходимо ввести число от 1 до 7.)");
    else Console.WriteLine($"{varA} -> нет"); 
    
}
    
    
    
    