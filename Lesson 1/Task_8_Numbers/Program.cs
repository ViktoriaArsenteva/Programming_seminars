// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число: ");
string N = Console.ReadLine();
int N1 = int.Parse(N);
int i = 2;
while (i <= N1)
{
    Console.Write(i);
    Console.Write(" ");
    
    i+=2;
}
