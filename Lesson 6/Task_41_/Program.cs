// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите количество чисел, которое необходимо обработать: ");
int amount = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int[amount];
Console.WriteLine($"Введите {amount} числа, используя клавишу ENTER: ");
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
int Counter (int[] Array)
{
    int i = 0;
    for (int index = 0; index < Array.Length; index++)
    {
        if (Array[i]>0) i++;
    }
    return i;
}
void PrintArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < Array.Length - 1) Console.Write(Array[i] + ",");
        else Console.Write(Array[i] + "]");
    }
}
int count = Counter(numbers);
PrintArray(numbers);
Console.WriteLine();
Console.WriteLine($"Количество чисел в данном массиве, которые больше нуля: {count}");