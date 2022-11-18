// на вход число
// проверяет кратно ли 7 и 23 одновременно
// 14 - нет
// 46 - нет
// 161 - да

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool MultiplicityToDigit(int num, int num1, int num2)
{
    return num % num1 == 0 && num % num2 == 0;
}

bool result = MultiplicityToDigit(number, 5, 31);

string resultStr = result ? "Да" : "Нет"; // тернарный оператор: если верно, записываем Да(?), если не верно, записываем Нет(:)
Console.WriteLine($"{number} -> {resultStr}");