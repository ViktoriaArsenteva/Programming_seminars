// Задача 16: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
Console.WriteLine("Введите два числа, чтобы проверить является одно квадратом другого");
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 * num1 == num2) { Console.WriteLine($"Да! Число {num1} является квадратом числа {num2} "); }
else if (num2 * num2 == num1) { Console.WriteLine($"Да! Число {num2} является квадратом числа {num1} "); }
else { Console.WriteLine($"Нет! Числа {num1} и {num2} не являются квадартами друг друга "); }