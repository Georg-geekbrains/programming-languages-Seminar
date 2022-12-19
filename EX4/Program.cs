Console.WriteLine("Введите целое число ");
string userInput = Console.ReadLine() ?? "";
int N = int.Parse(userInput);
Console.Write($"{N} ->");

int count = 2;


while (count <= N)
{
    Console.Write($" {count}, ");
    count += 2;
    
}
