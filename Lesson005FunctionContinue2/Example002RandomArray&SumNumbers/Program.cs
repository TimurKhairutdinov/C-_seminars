// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

int[] numbers = new int[12];
int start = -9; // start,end Диапазон случайных чисел.
int end = 10;
FillArray(numbers, start, end);
WriteArray(numbers);
GetSum(numbers);
int sumPositive = GetSumPositive(numbers);
int sumNegative = GetSumNegative(numbers);
Console.WriteLine(sumPositive);
Console.WriteLine(sumNegative);

void GetSum(int[] array)
{
    int positiveSum = 0;
    int negativeSum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (numbers[i] < 0)
        {
            positiveSum += numbers[i];
        }
        else
        {
            negativeSum += numbers[i];
        }
    }
    Console.WriteLine($"Сумма положительных чисел: {positiveSum}");
    Console.WriteLine($"Сумма отрицательных чисел: {negativeSum}");
}
int GetSumPositive(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (numbers[i] > 0)
        {
            sum += numbers[i];
        }
    }
    return sum;
}
int GetSumNegative(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (numbers[i] < 0)
        {
            sum += numbers[i];
        }
    }
    return sum;
}
void FillArray(int[] array, int start, int end)
{
    for (int i = 0; i < array.Length; i++)
    {
        numbers[i] = new Random().Next(start, end);
    }
}
void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}

