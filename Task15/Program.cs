// на вход цифру, обозначающую день недели
// проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);

bool DayOff(int num)
{
    return num == 6 || num == 7;
}

if (number > 0 && number < 8)
{
    bool dayOff = DayOff(number);
    Console.WriteLine(dayOff ? "Да" : "Нет");
}
else Console.WriteLine("Введите цифру от 1 до 7");