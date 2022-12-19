Console.WriteLine("Введите первое целое число");
string userInput1 = Console.ReadLine() ?? "";
int number1 = int.Parse(userInput1);

Console.WriteLine("Введите второе целое число");
string userInput2 = Console.ReadLine() ?? "";
int number2 = int.Parse(userInput2);

Console.WriteLine("Введите второе целое число") ;
string userInput3 = Console.ReadLine() ?? "";
int number3 = int.Parse(userInput3);

int max = number1;
if(number2 > max)
{
    max = number2;
}    
else if(number3 > max);
{
    max = number3;
}
Console.WriteLine($"Первое число - {number1}");
Console.WriteLine($"Первое число - {number2}");
Console.WriteLine($"Первое число - {number3}");
Console.WriteLine($"Максимальное число - {max}");