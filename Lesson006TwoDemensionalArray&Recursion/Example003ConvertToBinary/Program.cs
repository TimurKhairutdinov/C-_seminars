// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberBin = number;
int count = 0;
while (number != 0)
{
    number = number / 2;
    count++;
}
int[] binaryNumbers = new int[count];
int binary = 0;
for (int i = 0; i < binaryNumbers.Length; i++)
{
    binary = numberBin % 2;
    binaryNumbers[i] = binary;
    numberBin = numberBin / 2;
}
for (int i = 0; i < binaryNumbers.Length; i++)
{
    Console.Write($"{binaryNumbers[i]}");
}
Console.WriteLine();

for (int i = 0; i < binaryNumbers.Length / 2; i++)
{
    int temp = binaryNumbers[i];
    binaryNumbers[i] = binaryNumbers[binaryNumbers.Length - 1 - i];
    binaryNumbers[binaryNumbers.Length - 1 - i] = temp;
}
for (int i = 0; i < binaryNumbers.Length; i++)
{
    Console.Write($"{binaryNumbers[i]}");
}