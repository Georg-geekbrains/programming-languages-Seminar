//Задача 24. Напишите программу, которая принимает на вход число (А)
//и выдает сумму чисел от 1 до А (4-> (1+2+3+4) -> 10
Console.Clear();
int num = GetNumberFromUser("Введите число А: ", "Ошибка ввода");
//int numB = GetNumberFromUser("Введите число B: ", "Ошибка ввода");
//Console.Write($"{numA},{numB}");
int sumNumbers = GetSumNumber(num);
Console.WriteLine($"{num} -> {sumNumbers}");

// Выводит в консоль сообщение message,
// преобразовывает введенную пользователем строку в число типа int.
// В случае ошибки выводит в консоль сообщение errorMessage
int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
//Возвращает сумму чисел от 1 до number
int GetSumNumber(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum += number;
        number --;
    }
    return sum;
}