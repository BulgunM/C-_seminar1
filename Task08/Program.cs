﻿// на вход принимает число
// на выходе показывает все четные от 1 до N
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= number)
{
    if (count % 2 == 0)
    {
        Console.Write($"{count} ");
    }
    count++;
}