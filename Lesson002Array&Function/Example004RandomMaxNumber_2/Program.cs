// Задача 9. Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа.
int number = new Random().Next(10,100);

Console.WriteLine(number);
Console.WriteLine();
int first = number / 10; // Деление на 10 переносит запятую влево (15-->1,5) А тип данных int выводит только целые числа.
                            // И при делении (15/10) результатом будет 1, а не 1,5.
int second = number % 10; // Деление с остатоком % на 10, так же переносит запятую влево, но в результат деления записывает остаток от целого числа.
                            // Например, (15/10) результат в типе int будет 5.
                        // Для работы с дробными числами используется вещественный тип данных double.
int MaxNumber (int first,int second) // По спецификации Microsoft названия функций и классов пишутся с большой буквы.
{
    if (first > second) 
    {
        return first;
                                 // Фигурные скобки {} можно не ставить, если после условия производится только одно действие.
    }                           // Это касается всех конструкций, где используются фигурные скобки {}, кроме класса.
    else 
    {
        return second;
    }

}
int MaxNumber2 (int number1, int number2) // Функция поиска максимального числа, назначением переменной max.
{
    int max = number1;
    if (number2 > number1)
    {
        max = number2;
    }
    return max;
}
int MaxNumber3 (int a, int b) 
{
    int max = a;
    if (a>b)
    {
        max = a;
    }
    else 
    {
        max = b;
    }
    return max;
}
Console.WriteLine(MaxNumber(first, second));
Console.WriteLine();
Console.WriteLine(MaxNumber2(first, second));
Console.WriteLine();
Console.WriteLine(MaxNumber3(first, second));
