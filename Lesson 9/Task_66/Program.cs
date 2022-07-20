// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumOfNumbers(int n, int m)
{
    if (n == m) return m;
    return n + SumOfNumbers(n + 1, m);
}
Console.WriteLine("Введите два числа, чтобы найти сумму натуральных элементов между ними:");
Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = SumOfNumbers(m, n);
Console.WriteLine($"Сумма элементов в промежутке [{m},{n}] = {result}");
