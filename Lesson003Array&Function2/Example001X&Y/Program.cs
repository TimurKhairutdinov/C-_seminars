// Задача 17. Напишите программу, которая принимает на вход координаты точки (x,y), причём x != 0, y != 0,
// и выдаёт номер четверти плоскости, в которой находится эта точка. 
//     Y
//  1  |  2
// ____|____ X
//     |
//  3  |  4
// 
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());
// int.MaxValue Максимальное значение int.
// int.MinValue Минимальное значение int.
if (x == 0 || y == 0) // Две палочки || - оператор "или".
{
    Console.WriteLine("error");
    return;
}

int quarterNumber = 0;

if (x < 0 & y > 0)  // & или && - оператор "и". 
{
    quarterNumber = 1;
}

if (x > 0 & y > 0)
{
    quarterNumber = 2;
}

if (x < 0 & y < 0)
{
    quarterNumber = 3;
}

if (x > 0 & y < 0)
{
    quarterNumber = 4;
}

Console.Write($"Точка находится в чеверти номер: {quarterNumber}");
