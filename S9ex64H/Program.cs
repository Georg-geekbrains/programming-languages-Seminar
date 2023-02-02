/*Задача 64: Задайте значение N. Напишите программу,
 которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.Clear();
int m = GetNumberFromUser("Введите число M ", "Ошибка ввода");
Num(m);

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int Num(int m)
{
    int n = 1;
    Console.Write($"{m}, ");
    if (n == m)
        return n;
    else
        Num(m - 1);
    return m;
}

