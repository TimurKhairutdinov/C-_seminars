// Задача 32: Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] numbers = new int[5];

// FillArray(numbers);
RandomFillArray(numbers,-100,101);
Reverse(numbers);
void FillArray(int[] array)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }

}
void Reverse(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        numbers[i] = -numbers[i];
        Console.Write($"{numbers[i]} ");
    }
}
void RandomFillArray(int[]array, int start, int end)
{
    for (int i = 0; i < array.Length; i++)
    {
        numbers[i] = new Random().Next(start,end);
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}












