// Задача 14: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

int num1 = 7; int num2 = 23;
Console.Write($"Введите число, чтобы проверить его кратность числам {num1} и {num2}: ");
int number = Convert.ToInt32(Console.ReadLine());
int Multiple(int number1, int number2)
{
    if (number1 % number2 == 0) return 1;
    else return 0;
}
if (Multiple(number,num1) == 1 && Multiple(number,num2) == 1)
{
    Console.WriteLine($"Заданное число {number} одновременно кратно числам {num1} и {num2}");
}
else
{
    Console.WriteLine($"Заданоое число {number} не кратно числам {num1} и {num2}");
}

