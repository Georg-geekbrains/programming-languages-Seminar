//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит
//число A в натуральную степеньо B.
Console.Clear();
int numA = GetNumFromUser("Введите число A: ", "Ошибка ввода");
int numB = GetNumFromUser("Введите число B: ", "Ошибка ввода");
int power = GetPowerNumber(numA, numB);
Console.Write($"{numA} в степени {numB} -> {power}");

int GetNumFromUser(string message, string errorMessage)
{
    Console.Write(message);
    while (true)
    {
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.Write(errorMessage);
    }
}
int GetPowerNumber(int result1, int result2)
{
    int result = 1;
    for (int i = 1; i <= result2; i++)
    {
        result = result * result1;
    }
    return result;
}

