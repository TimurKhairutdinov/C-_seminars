// Напишите программу, которая выводит случайное трёх значное число и удаляет вторую цифру этого числа.
int number = RandomInt(100,1000);

int RandomInt(int a, int b)
{
    return new Random().Next(a,b);
}
Console.WriteLine(number);
int Total(int number)
{
    int a = number/100; // int a 516/100 = 5
    int c = number % 10;// int c 516 % 10 = 6
    int b = a*10+c;
    return b;
}

int Div3(int a)
{
    int b = a % 10;
    return b;
}

int Div2(int a)
{ 
    int b = a/10;
    int c = b%10;
    return c;
}

int Div1(int a)
{
    int b = a/100;
    return b;
}


void Plus(int a,int b) // Функция склеивания двух значений.
{
    Console.WriteLine(Convert.ToString(a) + Convert.ToString(b));
}


Console.Write(Div1(number));
// Console.WriteLine(Div2(number));
Console.WriteLine(Div3(number));

Console.WriteLine(Total(number)); // Одна функция на всё решение.

Console.WriteLine(Convert.ToString(Div1(number)) + Convert.ToString(Div3(number))); // Решение через "склеивание" переменных в string.

Plus((Div1(number)), (Div3(number)));