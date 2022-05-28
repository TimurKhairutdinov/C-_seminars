// Задача 45: Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

int[] array = new int[5];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,10);
    Console.Write(array[i]);
}
Console.WriteLine();
string copyArray = String.Empty;
for (int i = 0; i < array.Length; i++)
{
    copyArray += array[i];
}
Console.WriteLine(copyArray);