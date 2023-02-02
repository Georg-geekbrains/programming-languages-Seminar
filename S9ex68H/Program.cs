/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/


Console.Clear();
int m = GetNumberFromUser("Введите положительное число M ", "Ошибка ввода");
int n = GetNumberFromUser("Введите положительное число N ", "Ошибка ввода");

Akk(m, n);

Console.WriteLine($"Akk = {Akk(m, n)}");


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

int Akk(int m, int n)
{

    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akk(m - 1, 1);
    else
        return Akk(m - 1, Akk(m, n - 1));
}
