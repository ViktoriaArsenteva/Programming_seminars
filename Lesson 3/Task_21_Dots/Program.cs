// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Вам необходимо ввести коордианты двух точек A(x;y;z) и B(x;y;z) для нахождения расстояния между ними");
Console.WriteLine("Введите координаты точки A: ");
Console.Write("x = ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("z = ");
int az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: ");
Console.Write("x = ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("z = ");
int bz = Convert.ToInt32(Console.ReadLine());
double result = Math.Round(Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay) + (bz - az) * (bz - az)), 2);
Console.WriteLine($"Расстояние между точками A({ax};{ay};{az}) и B({bx};{by};{bz}) = {result}");

