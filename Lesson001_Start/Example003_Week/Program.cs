// Задача 2. Программа, которая выдаёт название дня недели по заданному номеру.

Console.Write("Введите число: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1)
{
    Console.Write("Понедельник");
}
if (day == 2)
{
    Console.Write("Вторник");
}
if (day == 3)
{
    Console.Write("Среда");
}
if (day == 4)
{
    Console.Write("Четверг");
}
if (day == 5)
{
    Console.Write("Пятница");
}
if (day == 6)
{
    Console.Write("Суббота");
}
if (day == 7)
{
    Console.Write("Воскресенье");
}
if (day > 7)
{
    Console.Write("В неделе семь дней, введите число от 1 до 7");
}
else 
{
    if (day == 0)
    {
        Console.Write("В неделе семь дней, введите число от 1 до 7");
    }
}