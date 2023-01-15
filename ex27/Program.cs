//Задача 27: Напишите программу, которая принимает на вход число и выдает сумму
//цифр в числе 452 -> 11
Console.Clear();
int num = GetNumberFromUser("Введите число: ", "Ошибка ввода");
int Sum = GetSumDig(num);
Console.Write($"{num} -> {Sum}");

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
int GetSumDig(int number)
{
    int sum = 0;
    while ( number > 0)
    {
        int t = number % 10;
        sum += t;
        number = number/10;
    }
    return sum;
}