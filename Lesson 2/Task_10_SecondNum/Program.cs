// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = Math.Abs(num);
List<int> Numbers = new List<int>();
while (num1 != 0)
{
    Numbers.Add(num1 % 10);
    num1 /= 10;
}
Numbers.Reverse();
Console.Write($"Вторая цифра числа {num}: ");
Console.WriteLine(Numbers[1]);