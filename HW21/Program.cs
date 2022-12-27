/*Задача 21
 Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.*/

Console.Write("Введите значение X для точки A: ");
int ax = int.Parse(Console.ReadLine()?? "");
Console.Write("Введите значение Y для точки A: ");
int ay = int.Parse(Console.ReadLine()?? "");
Console.Write("Введите значение Z для точки A: ");
int az = int.Parse(Console.ReadLine()?? "");

Console.Write("Введите значение X для точки B: ");
int bx = int.Parse(Console.ReadLine()?? "");
Console.Write("Введите значение Y для точки B: ");
int by = int.Parse(Console.ReadLine()?? "");
Console.Write("Введите значение Z для точки B: ");
int bz = int.Parse(Console.ReadLine()?? "");

double result = Math.Sqrt(Math.Pow((bx-ax),2) + Math.Pow((by-bx),2) + Math.Pow((bz-az),2));
Console.WriteLine($"{result}");