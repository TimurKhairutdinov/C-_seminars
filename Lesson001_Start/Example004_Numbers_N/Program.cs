// Задача. Написать программу, которая на вход принимает одно число N, 
// а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Введите число: ");
int NumberOne = Convert.ToInt32(Console.ReadLine());
int NumberTwo = (NumberOne * -1); // Можно сделать int b = - a;
while ( NumberTwo <= NumberOne )
{
    Console.Write(NumberTwo + ", ");
    NumberTwo++;
}