// принимает на вход число
// выдает квадрат числа

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 - преобразовывает строку, которую ввели через ReadLine, в переменную int
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");
