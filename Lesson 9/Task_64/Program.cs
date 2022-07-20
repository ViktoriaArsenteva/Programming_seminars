// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
void PrintNumbers(int firstNum, int secondNum)
{
    if (firstNum == secondNum) Console.Write(secondNum);
    else 
    {
        Console.Write($"{firstNum}, ");
        PrintNumbers(firstNum + 1, secondNum);
    }
}
Console.WriteLine("Введите два числа, чтобы увидеть все натуральные числа между ними: ");
Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Натуральные числа в промежутке [{m},{n}]:");
PrintNumbers(m, n);
