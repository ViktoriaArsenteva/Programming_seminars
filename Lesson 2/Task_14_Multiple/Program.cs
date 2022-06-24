// Задача 14: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

int num1 = 7; int num2 = 23;
Console.Write($"Введите число, чтобы проверить его кратность числам {num1} и {num2}: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % num1 == 0 && number % num2 == 0)
{
    Console.WriteLine($"Заданное число {number} одновременно кратно числам {num1} и {num2}");
}
else
{
    Console.WriteLine($"Заданоое число {number} не кратно числам {num1} и {num2}");
}