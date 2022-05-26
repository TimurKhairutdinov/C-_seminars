// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
Console.Write("Введите размера массива: ");
int size = Convert.ToInt32(Console.ReadLine());
// size - размер массива // -99 и 100 диапазон чисел для заполнения массива
int[] array = GetRandomArray(size,-99,100);
WriteArray(array);
// Решение с семинара
for(int i = 0; i< array.Length/2;i++)    
{
    int temp = array[i];                    
    array[i] = array[array.Length-1-i];
    array[array.Length-1-i] = temp;
}
WriteArray(array);
// Моё решение
/* int[] reverseArray = new int[size];
int j = array.Length-1;
for (int i = 0; i < array.Length; i++)
{
    reverseArray[i] = array[j-i];
}
WriteArray(reverseArray); */

int[] GetRandomArray(int length,int start,int end)
{
    int[] newArray = new int[length];
    RandomFillArray(newArray,start,end);
    return newArray;
}
void RandomFillArray(int[] array,int start,int end)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(start,end);
    }
}
void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0)
        {
            Console.Write("[");
        }
        Console.Write(array[i]);
        if (i + 1 < array.Length)
        {
            Console.Write(",");
        }
        else
        {
            Console.Write("]");
        }
    }
    Console.WriteLine();
}