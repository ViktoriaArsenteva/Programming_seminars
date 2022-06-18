//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите число, чтобы узнать его четность: ");
double Num = Convert.ToDouble(Console.ReadLine());
if (Num % 2 == 0)
{
    Console.WriteLine($"Да! Число {Num} четное");
}
else
{
    Console.WriteLine($"Нет! Число {Num} нечетное");
}

