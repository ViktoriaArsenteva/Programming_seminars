// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int AckermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if ((n == 0) && (m!= 0)) return AckermanFunction(m - 1, 1);
    else return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}
Console.WriteLine("Введите два числа для вычисления функции Аккермана: ");
Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = AckermanFunction(m, n);
Console.WriteLine($"Значение функции = {result}");