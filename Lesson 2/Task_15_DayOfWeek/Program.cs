// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 1){Console.WriteLine("Понедельник - будний день");}
else if (day == 2){Console.WriteLine("Вторник - будний день");}
else if (day == 3){Console.WriteLine("Среда - будний день");}
else if (day == 4){Console.WriteLine("Четверг - будний день");}
else if (day == 5){Console.WriteLine("Пятница - будний день");}
else if (day == 6){Console.WriteLine("Суббота - выходной день!");}
else if (day == 7){Console.WriteLine("Воскресенье - выходной день!");}
else {Console.WriteLine("Ошибка ввода! (введите число от 1 до 7)");}