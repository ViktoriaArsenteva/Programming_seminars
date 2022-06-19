// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"Последняя цифра числа {num}: ");
Console.WriteLine(num % 10);
