// выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа
// 78 - 8
// 12 - 2
// 85 - 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка [10, 99] --> {number}");

// int firstDigit = number / 10; // первая цифра числа
// int secondDigit = number % 10; // вторая цифра числа

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа --> {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа --> {secondDigit}");

// Console.WriteLine($"Наибольшая цифра числа --> {Math.Max(firstDigit, secondDigit)}"); встроенный метод нахождения максимального

int MaxDigit(int num) // int num = number глобальная переменная number присваивается параметру метода int num 
{
    int firstDigit = num / 10; // первая цифра числа
    int secondDigit = num % 10; // вторая цифра числа
    if (firstDigit > secondDigit) return firstDigit;
    return secondDigit;
}

int maxDigit = MaxDigit(number);
int maxDigit2 = MaxDigit(23);
int maxDigit3 = MaxDigit(78);
int maxDigit4 = MaxDigit(99);

Console.WriteLine($"Наибольшая цифра числа --> {maxDigit}");
Console.WriteLine($"Наибольшая цифра числа --> {maxDigit2}");
Console.WriteLine($"Наибольшая цифра числа --> {maxDigit3}");
Console.WriteLine($"Наибольшая цифра числа --> {maxDigit4}");