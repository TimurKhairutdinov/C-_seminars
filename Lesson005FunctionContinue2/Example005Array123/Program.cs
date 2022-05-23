// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 

int[] numbers = new int[123];
int start = 0;
int end = 1000;
RandomFillArray(numbers, start, end);
WriteArray(numbers);
int rangeFrom = 10;
int rangeTo = 99;
int countNumbers = CountNumberInArray(numbers,rangeFrom,rangeTo);
Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке от {rangeFrom} до {rangeTo} равно: {countNumbers}");

void RandomFillArray(int[] array, int start, int end)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(start, end);
    }
}
void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int CountNumberInArray(int[] array, int start, int end)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= start && array[i] <= end)
        {
            count++;
        }
    }
    return count;
}