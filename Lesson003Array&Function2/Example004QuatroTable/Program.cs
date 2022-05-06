// Напишите программу, которая принимает на вход число N и выдаёт таблицу квадратов чисел от 1 до N.
Console.Write("N: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Степень преобразования: ");
int stepen = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= number)
{
    int countQuatro = Convert.ToInt32(Math.Pow(count,stepen));
    Console.WriteLine($"{count}^{stepen} = {countQuatro}");
    count++;
}
