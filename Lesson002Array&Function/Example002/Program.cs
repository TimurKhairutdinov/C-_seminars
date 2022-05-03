int[] numbers1 = new int [3]; // Создание массива без объявления типа не работает. Почему-то.
int[] numbers2 = new int [5];

void FillIntArray (int[] array) // Процедура заполнения массива. Без возвращаемого значения.

{
    int index = 0;
    while (index < array.Length)
    {
        array[index] = new Random().Next(0,100);
        Console.Write(array[index] + ", ");
        index++;
    }

}

int Sum (int a, int b) //Функция возвращает значение. В данном случае  return sum; 
{
    int sum = a + b;
    return sum;
}

int sum = Sum(4,5); // Переменная для записи результата отработанной функции Sum.

FillIntArray(numbers1);
Console.WriteLine();
FillIntArray(numbers2);     
Console.WriteLine();
Console.WriteLine(Sum(5,5));
