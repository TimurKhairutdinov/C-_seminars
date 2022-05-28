// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

int ab = Input("AB");
int ac = Input("AC");
int bc = Input("BC");
if (ab < ac + bc && bc < ab + ac && ac < ab + bc)
{
    Console.WriteLine("Треугольник может существовать!");
}
else 
{
    Console.WriteLine("Треугольник не может существовать!");
}

int Input(string name)
{
    Console.Write($"Введите сторону {name}: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}