// на вход 2 числа
// выводит кратно ли первое число второму
// если первое не кратно, выводит остаток от деления
// 34, 5 - не кратно, остаток 4
// 16, 4 - кратно

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

int Modulo(int num1, int num2)
{
    return num1 % num2;
    // if (num1 % num2 == 0) //Console.WriteLine($"Число {number1} кратно числу {number2}");
    // if (num1 % num2 != 0) //Console.WriteLine($"Число {number1} не кратно числу {number2}");
}

int modulo = Modulo(number1, number2);
if (modulo == 0)
{
    Console.WriteLine("Кратно");
}
else Console.WriteLine($"Не кратно, остаток от деления равен {modulo}");



