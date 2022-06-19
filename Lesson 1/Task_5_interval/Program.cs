//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n2 = n * (-1);
Console.WriteLine($"Целые числа в промежутке [{n2};{n}]:");
for (int i = n2; i <= n; i++)
{
    Console.Write(i);
    Console.Write(" ");
}