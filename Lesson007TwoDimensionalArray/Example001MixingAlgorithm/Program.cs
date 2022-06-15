int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };

for (int i = 0; i < arr.Length; i++)
{
    int randomIndex = new Random().Next(0, arr.Length);
    int temp = arr[i];
    arr[i] = arr[randomIndex];
    arr[randomIndex] = temp;
}

Console.WriteLine();

for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
