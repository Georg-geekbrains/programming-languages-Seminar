Console.WriteLine("Введите целое число ");
string userInput = Console.ReadLine() ?? "";
int number = int.Parse(userInput);

int num = number%2;
//Console.WriteLine($"значение {num}");
if(num == 0)
{
    Console.WriteLine($"Вы ввели число {number} - оно четное");
}
else 
{
Console.WriteLine($"Вы ввели число {number} - оно не четное");
}