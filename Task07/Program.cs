// на вход трехзначное число
// на выход отображает последнюю цифру числа

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int result = number % 10;
Console.WriteLine($"Последняя цифра {result}");