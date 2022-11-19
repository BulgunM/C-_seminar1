// на вход трёхзначное число 
// показывает вторую цифру этого числа

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);

int SecondDigit(int num)
{
    return num % 100 / 10;
}

if (number > 99 && number < 1000)
{
    int secondDigit = SecondDigit(number);
    Console.WriteLine($"Вторая цифра числа {number} -> {secondDigit}");
}
else Console.WriteLine("Введенное число не является трехзначным");