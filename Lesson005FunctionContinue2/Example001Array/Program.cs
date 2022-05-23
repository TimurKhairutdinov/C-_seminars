// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] number = new int[8];
for (int i = 0; i < number.Length; i++)
{
    Console.Write($"Введите число {i+1}: ");
    number[i] = Convert.ToInt32(Console.ReadLine());        
} 
