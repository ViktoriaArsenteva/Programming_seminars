//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
string FirstNum = Console.ReadLine();
int Num1 = int.Parse(FirstNum);
Console.Write("Введите второе число: ");
string SecondNum = Console.ReadLine();
int Num2 = int.Parse(SecondNum);
if (Num1 > Num2)
{
    Console.Write("Большее число: ");
    Console.WriteLine(Num1);
    Console.Write("Меньшее число: ");
    Console.WriteLine(Num2);
}

else
{
    Console.Write("Большее число: ");
    Console.WriteLine(Num2);
    Console.Write("Меньшее число: ");
    Console.WriteLine(Num1);
}

    