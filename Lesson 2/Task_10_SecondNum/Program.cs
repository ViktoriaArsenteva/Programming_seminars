// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
List<int> numbers = new List<int>();
Console.Write($"Вторая цифра числа {num}: ");
while (num != 0)
{
    numbers.Add(num % 10);
    num /= 10;
}
numbers.Reverse();
Console.WriteLine(numbers[1]);