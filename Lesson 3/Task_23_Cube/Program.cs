// Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
Console.WriteLine($"Кубы чисел прмежутка [1;{n}]:");
Console.Write(i);
while (i != n)
{
    i++;
    Console.Write($", {i * i * i}");
}