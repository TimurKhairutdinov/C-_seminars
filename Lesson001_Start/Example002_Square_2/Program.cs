// Задача 1. Программа, которая принимает 2 числа и проверяет, является ли первое квадратом второго.

Console.Write("Введите первое число: ");
int NumberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int NumberTwo = Convert.ToInt32(Console.ReadLine());
double square = NumberTwo / NumberOne;
Console.WriteLine("Является ли первое число квадратом второго?");
if (square == NumberOne)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}