// Напишите программу, которая по заданному номеру четверти, 
//  показывает диапазон возможных координат точек в этой четверти (x & y).
Console.Write("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());
int min = int.MinValue;
int max = int.MaxValue;
if (quarter <= 0 || quarter > 4)
{
    Console.WriteLine("Error");
    return;
}
if (quarter == 1)
{
    Console.WriteLine($"Диапазон для X: от {min} до 0");
    Console.WriteLine($"Диапазон для Y: от 0 до {max}");
}
if (quarter == 2)
{
    Console.WriteLine($"Диапазон для X: от 0 до {max}");
    Console.WriteLine($"Диапазон для Y: от 0 до {max}");
}
if (quarter == 3)
{
    Console.WriteLine($"Диапазон для X: от {min} до 0");
    Console.WriteLine($"Диапазон для Y: от {min} до 0");
}
if (quarter == 4)
{
    Console.WriteLine($"Диапазон для X: от 0 {max}");
    Console.WriteLine($"Диапазон для Y: от {min} до 0");
}
