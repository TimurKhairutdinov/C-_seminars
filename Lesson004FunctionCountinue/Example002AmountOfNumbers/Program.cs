// Задача 26. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// Ввод числа через консоль. 
string numbers = Console.ReadLine();
// Переменная размер массива.
int size = numbers.Length;
// Вывод размера в консоль.
Console.WriteLine(size);

// Решение через переменную int
int numbers2 = Convert.ToInt32(Console.ReadLine());
int qty = 0; // qty == qountity 
while (numbers2 != 0)
{
    numbers2 = numbers2/10;
    qty++;
}
Console.WriteLine(qty);