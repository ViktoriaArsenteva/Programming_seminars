// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число, чтобы узнать сумму его цифр: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = number; i != 0; i /= 10)
{
    sum += i % 10;
}
Console.WriteLine($"Сумма цифр числа {number} = {sum}");