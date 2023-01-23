/*Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.*/

Console.Clear();
int[] array = GetUserArray(8);
int amountOfNumbers = AmountNumbers(array);
Console.WriteLine($"[ {String.Join(", ", array)} ]");
Console.WriteLine($"Количество положительных чисел: {amountOfNumbers}");

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

int[] GetUserArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        int n = GetNumberFromUser("Введите число: ", "Ошибка ввода");
        arr[i] = n;
    }
    return arr;
}

int AmountNumbers(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) result++;
    }
        return result;
}





