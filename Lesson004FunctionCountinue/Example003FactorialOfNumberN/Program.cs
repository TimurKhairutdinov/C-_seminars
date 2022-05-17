// Задача 28. Напишите программу, которая принимает на вход число N выдаёт произведение чисел от 1 до N.

int number = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 1; i <= number; i++)
{
    result *= i;
    //result = result * i;
}
Console.WriteLine(result);
