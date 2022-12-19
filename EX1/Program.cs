Console.WriteLine("Введите первое целое число");
string userInput1 = Console.ReadLine() ?? "";
int number1 = int.Parse(userInput1);

Console.WriteLine("Введите второе целое число");
string userInput2 = Console.ReadLine() ?? "";
int number2 = int.Parse(userInput2);

if(number1 > number2)
{
    Console.WriteLine($"Максимальное число {number1}");
    Console.WriteLine($"Минимальное число {number2}");
}
else 
{
    Console.WriteLine($"Максимальное число {number2}");
    Console.WriteLine($"Минимальное число {number1}");
}