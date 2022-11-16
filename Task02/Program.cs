// на вход принимает 2 числа
// на выходе выдает максимальное и минимальное
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

int max = number1;
int min = number2;

if (number2 > number1)
{
    max = number2;
    min = number1;
}
Console.WriteLine($"{max} больше, чем {min}");