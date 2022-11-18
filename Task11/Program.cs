// выводит случайное трехзначное число
// удаляет вторую цифру числа
// 456 - 46
// 782 - 72
// 918 - 98

int number = new Random().Next(99, 1000);
Console.WriteLine($"Случайное число {number}");

// int firstDigit = number / 100;
// int secondDigit = number % 10;

// Console.WriteLine($"{firstDigit}{secondDigit}");

int NewNumber(int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    int result = firstDigit * 10 + secondDigit;
    return result;
}

int newNumber = NewNumber(number);
Console.WriteLine($"{newNumber}");