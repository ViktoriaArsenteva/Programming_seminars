// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите число, чтобы выяснить является ли оно палендромом: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int number = num1;
List<int> Numbers = new List<int>();
while (number != 0)
{
    Numbers.Add(number % 10);
    number /= 10;
}
int i = 0;
int lenght = Numbers.Count / 2;
bool check = false;
while (lenght != 0)
{
    if (Numbers[i] == Numbers[Numbers.Count - 1 - i])
    {
        check = true;
    }
    else
    {
        check = false;
        break;

    }
    i++;
    lenght--;
}
if (check == true)
{
    Console.WriteLine($"Да! Число {num1} является палиндромом");
}
else
{
    Console.WriteLine($"Нет! Число {num1} не является палиндромом");
}