//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int N2 = N * (-1);
Console.WriteLine($"Целые числа в промежутке [{N2};{N}]:");
 for (int i = N2; i <= N; i++ ) 
 {
     Console.Write(i);
     Console.Write(" ");
 }