//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.




Console.WriteLine("Введите три числа: ");
int[] Numbers = new int[] {0,0,0};
int i = 0;
int k = 1;
while (i < Numbers.Length)
{
    string Num = Console.ReadLine();
    Numbers[i] = int.Parse(Num);
    i++;
}
int max = Numbers[0];
while (k < Numbers.Length)
{
    if (Numbers[k]> max)
    {
        max = Numbers[k];
    }
    k++;
}
Console.Write("Максимальное число: ");
Console.WriteLine(max);
