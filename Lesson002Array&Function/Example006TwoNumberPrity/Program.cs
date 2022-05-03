// Задача 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе кратное первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
int number1 = new Random().Next(10, 100);
int number2 = new Random().Next(2, 10);
void Print(int a, int b)
{
    Console.WriteLine(a);
    Console.WriteLine(b);
}

void Parity(int a, int b)
{
    int c = a % b;
    if (c == 0)
    {
        Console.WriteLine("yes " + c);

    }
    else
    {
        Console.WriteLine("no " + c);
    }
}


Print(number1, number2);
Parity(number1, number2);
