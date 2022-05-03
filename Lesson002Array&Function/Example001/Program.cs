//
int Sum(int number1, int number2)
{
    int sum = number1+number2;
    return sum;
}

int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int sum = Sum(num1, num2);
Console.WriteLine(sum);


// Типы объявления массивов:
int [] numbers1 = {1,3,4,5,6};
int [] numbers2 = new int[5];
int [] numbers3 = new[5];
int [] numbers4; // Массив объявлен, но не проинициализирован.
// Если в массив не заполен, то при создании он заполнится пустыми значениями, исходя из типа данных.

int number = 0; // 0
string str = ""; // Пустая строка.
bool b1 = false; // false.
