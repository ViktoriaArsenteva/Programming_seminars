//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int Num2 = Convert.ToInt32(Console.ReadLine());
if (Num1 > Num2)
{
    Console.WriteLine($"Большее число: {Num1}");
    Console.WriteLine($"Меньшее число: {Num2}");
}
else
{
    Console.WriteLine($"Большее число: {Num2}");
    Console.WriteLine($"Меньшее число: {Num1}");
}

