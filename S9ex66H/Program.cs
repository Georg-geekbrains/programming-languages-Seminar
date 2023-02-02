/*Задача 66: Задайте значения M и N. Напишите программу,
 которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/


Console.Clear();
int m = GetNumberFromUser("Введите число M ", "Ошибка ввода");
int n = GetNumberFromUser("Введите число N ", "Ошибка ввода");

Sum(m,n);

Console.WriteLine($"M = {m}; N = {n} -> {Sum(m, n)}");


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

int Sum(int m, int n)
{

    if (m == n)
	return n;
	return n + Sum(m, n - 1);   
}