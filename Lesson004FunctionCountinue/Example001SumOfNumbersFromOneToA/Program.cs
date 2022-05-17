// Задача 24. Напишите программу, которая принимает на вход число A и выдаёт сумму чисел от 1 до А.
Console.Write("Введите число: ");
int numbers = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= numbers; i++)
{
    sum += i;
    //sum = sum + i;
}
Console.WriteLine("Ответ: " + sum);