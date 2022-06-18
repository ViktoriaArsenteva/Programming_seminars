//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Введите число: ");
string N = Console.ReadLine();
int N1 = int.Parse(N);
int N2 = N1 * (-1);
 for (int i = N2; i <= N1; i++ ) 
 {
     Console.Write(i);
     Console.Write(" ");
 }