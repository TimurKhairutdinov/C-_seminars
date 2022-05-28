// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// f(n) = f(n-1)+f(n-2)
int number = Input();
double[] fibonacci = new double[number];
int i = 0;
if (number > 0)
{
    fibonacci[0] = 0;
    Console.WriteLine($"1 = {fibonacci[0]} ");
    if (number > 1)
    {
        fibonacci[1] = 1;
        Console.WriteLine($"2 = {fibonacci[1]} ");
        for (i = 2; i < fibonacci.Length; i++)
        {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            Console.WriteLine($"{i + 1} = {fibonacci[i]} ");
        }
    }
}

int Input()
{
    Console.Write("Введите число: ");
    int newNumber = Convert.ToInt32(Console.ReadLine());
    return newNumber;
}
/* int GetIndex(int currentIndex, int length)
{
    if (currentIndex + 1 >= length || currentIndex - 1 < 0)
    {
        currentIndex = 0;
    }
    return currentIndex;
}
 */