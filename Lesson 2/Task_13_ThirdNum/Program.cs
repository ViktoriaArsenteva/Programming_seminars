// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = Math.Abs(num);
List<int> numbers = new List<int>();
Console.WriteLine(numbers);
while (i != 0)
{
    numbers.Add(i % 10);
    i /= 10;
}
numbers.Reverse();
if (numbers.Count < 3)
{
    Console.WriteLine($"Третьей цифры в числе {num} нет");
}
else
{
    Console.WriteLine($"Третья цифра числа {num}: {numbers[2]}");
}