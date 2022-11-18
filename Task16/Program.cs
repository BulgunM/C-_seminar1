// на вход 2 числа
// проверяет является ли одно число квадратом другого
// 5, 25 - да
// -4, 16 - да
// 25, 5 - да
// 8, 9 - нет

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

bool ISSquare(int num1, int num2)
{
    return num1 * num1 == num2 || num2 * num2 == num1;
}

bool square = ISSquare(number1, number2);

Console.WriteLine(square ? "Да" : "Нет");