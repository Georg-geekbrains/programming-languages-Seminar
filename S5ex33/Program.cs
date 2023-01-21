/*Задача 33. Задайте массив. Напишите программу, которая определяет присутсвует ли
данное число в массиве*/

Console.Clear();
int usernum = GetNumberOfUser("Введите проверяемое число; ", "Ошибка ввода");
int [] array = GetArray(10, 1, 15);
bool inarray = Check(usernum, array);
Console.WriteLine($"{usernum} [ {String.Join(", ", array)} ] {(inarray ? "да" : "нет")}");

int GetNumberOfUser(string message, string error)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
        return userNumber;
        Console.WriteLine(error);
    }
    
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < res.Length; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
return res;
}

bool Check(int usernum, int[] array)
{
for(int i = 0; i < array.Length; i++)
{
    if(usernum == array[i]) 
    return true;
}    
return false;
}