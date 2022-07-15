// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = Math.Abs(num);
List<int> Numbers = new List<int>();
Console.WriteLine(Numbers);
while (i != 0)
{
    Numbers.Add(i % 10);
    i /= 10;
}
Numbers.Reverse();
if (Numbers.Count < 3)
{
    Console.WriteLine($"Третьей цифры в числе {num} нет");
}
else
{
    Console.WriteLine($"Третья цифра числа {num}: {Numbers[2]}");
}