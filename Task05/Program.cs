// на входе натуральное (которое считает) целое число
// на выходе все числа в промежутке от -N до N

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
int count = -number;

while (count <= number)
{
    Console.Write($"{count} ");
    count++;
}

