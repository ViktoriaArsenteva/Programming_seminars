// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
void PrintNumbers(int firstNum, int secondNum)
{
    for (int i = firstNum; i <= secondNum; i++)
    {
        if (i == secondNum)
        {
            Console.Write(i);
        }
        else
        {
            Console.Write($"{i}, ");
        }
    }
}
Console.WriteLine("Введите два числа, чтобы уидеть все натуральные числа между ними: ");
Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Натуральные числа в промежутке [{m},{n}]:");
PrintNumbers(m,n);
