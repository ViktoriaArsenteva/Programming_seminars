//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите три числа: ");
int[] numbers = new int[] { 0, 0, 0 };
int i = 0;
int k = 1;
while (i < numbers.Length)
{
    numbers[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}
int max = numbers[0];
while (k < Numbers.Length)
{
    if (numbers[k] > max)
    {
        max = numbers[k];
    }
    k++;
}
Console.WriteLine($"Максимальное число: {max}");

