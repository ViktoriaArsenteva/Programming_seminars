// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
Console.Write("Введите число: ");
String Number = Console.ReadLine();
double Num = double.Parse(Number);
Console.WriteLine(Num % 10);
