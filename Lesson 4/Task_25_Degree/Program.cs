// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень, в которую необходимо возвести первое число: ");
int degree = Convert.ToInt32(Console.ReadLine());
int DegreeOfNumber(int num1, int deg)
{
    int result = 1;
    for (int i = 1; i <= deg; i++)
    {
        result *= num1;
    }
    return result;
}
int answer = DegreeOfNumber(number, degree);
Console.WriteLine($"Число {number} в степени {degree} = {answer}");
