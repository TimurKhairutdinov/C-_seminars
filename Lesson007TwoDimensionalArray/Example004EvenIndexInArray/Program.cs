// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив 
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4 
// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] table = new int[rows, columns];

RandomFillArray(table, 0, 10);
PrintArray(table);

for (int i = 1; i < table.GetLength(0); i++)
{
    if (i % 2 == 0)
    {
        for (int j = 1; j < table.GetLength(1); j++)
        {
            if (j % 2 == 0)
            {
                table[i, j] *= table[i, j];
            }
        }
    }
}

PrintArray(table);

void RandomFillArray(int[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
