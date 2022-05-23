// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] numbers = new int[5];
int start = 2;
int end = 10;
int length = numbers.Length / 2;
bool parity = true;
if (numbers.Length % 2 != 0)
{
    parity = false;
    length++;
}
int[] newNumbers = new int[length];
RandomFillArray(numbers, start, end);
PrintArray(numbers);
Pairs(numbers, newNumbers, parity);
PrintArray(newNumbers);

void Pairs(int[] array, int[] newArray, bool parity)
{
    int j = array.Length - 1;
    int sum = 0;
    int length = newArray.Length;
    for (int i = 0; i < length; i++)
    {
        sum = array[i] * array[j];
        newArray[i] = sum;
        if (parity == false && i + 1 == length)
        {
            newArray[i] = array[j];
        }
        j--;
    }
}
void RandomFillArray(int[] array, int start, int end)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(start, end);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

