// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
Console.Write("Введите число: ");
double Num = Convert.ToDouble(Console.ReadLine());
Console.Write($"Последняя цифра числа {Num}: ");
Console.WriteLine(Num % 10);
