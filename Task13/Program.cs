// на вход число
// выводит третью цифру заданного числа или сообщает, что третьей цифры нет

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);

int ThirdDigit(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    return num % 100 % 10;
}
if (number > 99)
{
    int result = ThirdDigit(number);
    Console.WriteLine($"Третья цифра числа: {result}");
}
else Console.WriteLine("Третьей цифры нет");


