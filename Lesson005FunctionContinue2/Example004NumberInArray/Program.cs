// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


int[] numbers = new int[5];
FillArray(numbers);

Console.Write("Введите искомое число: ");
int findNumber = Convert.ToInt32(Console.ReadLine());
if(findNumber < 0)
{
    findNumber = -findNumber;
}
FindNumber(numbers, findNumber);

void FillArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}
void FindNumber(int[] numbers, int findNumber)      
{
    for (int i = 0; i < numbers.Length; i++)
    {   
        if(numbers[i] < 0)
        {
            numbers[i] = -numbers[i];
        }
        if (numbers[i] == findNumber)
        {
            Console.WriteLine($"Число {findNumber} найдено, индекс: {i}");
            break; 
        }
        if (i + 1 == numbers.Length)
        {
            Console.WriteLine("Число отсутствует!");
        }
    }
}
