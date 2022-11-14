// на вход принимает 2 числа
// проверяет: первое квадрат второго или нет
// 25, 5 - да
// 2, 10 - нет
// 9, -3 - да
// -3, 9 - нет

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

int square = number2 * number2;

if (square == number1)
{
    Console.WriteLine($"Число {number1} является квадратом числа {number2}");
}
else
{
    Console.WriteLine($"Число {number1} не является квадратом числа {number2}");
}