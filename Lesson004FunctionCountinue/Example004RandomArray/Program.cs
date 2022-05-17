// Задача 30. Напишите программу,которая выводит массив из 8 элементов заполненный нулями и единицами в случайном порядке.

int[] randomArr = new int[8];
int start = 0; // Диапазон
int end = 2;

for (int i = 0; i < randomArr.Length; i++)
{
    randomArr[i] = new Random().Next(start, end);
    Console.Write($"{randomArr[i]}");
    // Условие при выполнении которого ставится запятая, пока общий цикл не дойдёт до последней цифры массива. 
    if (i < randomArr.Length - 1) 
        {
            Console.Write(",");
        }
}

Console.WriteLine();
// Решение задачи через строку.
string numbers = String.Empty;
for (int j = 0; j < randomArr.Length; j++)
{   
    randomArr[j] = new Random().Next(start, end);
    // Склеивание цифр
    numbers += randomArr[j];
    // Условие при выполнении которого ставится запятая, пока общий цикл не дойдёт до последней цифры массива
    if (j < randomArr.Length - 1) 
        {
            numbers += ',';
        }
}
Console.WriteLine(numbers);