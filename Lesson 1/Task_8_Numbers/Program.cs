// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 2;
Console.WriteLine($"Четные числа в промежутке [1;{N}]");
while (i <= N)
{
    Console.Write(i);
    Console.Write(" ");
    i += 2;
}
