Console.WriteLine("Введите целое трёхзначное числ:");
string userInput = Console.ReadLine() ?? "";
int number = int.Parse(userInput);

int num2 = number % 100 / 10;
Console.WriteLine($"{number} ->   {num2}");
