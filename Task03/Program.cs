﻿// вводится число
// выдает названиедня недели

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine("Monday");
}
else if (number == 2)
{
    Console.WriteLine("Tuesday");
}
else if (number == 3)
{
    Console.WriteLine("Wednesday");
}
else if (number == 4)
{
    Console.WriteLine("Thursday");
}
else if (number == 5)
{
    Console.WriteLine("Friday");
}
else if (number == 6)
{
    Console.WriteLine("Saturday");
}
else if (number == 7)
{
    Console.WriteLine("Sunday");
}
else
{
    Console.WriteLine("Число не соответствует дню недели");
}