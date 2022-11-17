// на вход принимает число
// выдает четное или нет
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
if (number % 2 == 0)
{
    Console.WriteLine("Число чётное"); // "число является четным"
}
else
{
    Console.WriteLine("Число нечётное"); // "число не является четным"
}