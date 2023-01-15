// Задача 26: Напишите программу, которая
// принимает на вход число и выдает количество цифр в числе

Console.Clear();
int num = GetUserFromNumber("Введите число: ", "Ошибка ввода");
int CountNumber = GetCountNumber(num);
Console.Write($"{num} -> {CountNumber} ");

int GetUserFromNumber(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.Write(errorMessage);
    }
}
int GetCountNumber(int number)
{
    int count = 0;
    while (number > 0)
    {
        number = number / 10;
        count ++;
    }
        return count;
    
}