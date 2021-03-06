/* Задача 21. Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 2D пространстве 

*/

int xA = Coordinate("x", "A"); 
int yA = Coordinate("y", "A"); 
int xB = Coordinate("x", "B"); 
int yB = Coordinate("y", "B"); 

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}



int xC = xA;
int yC = yB;

Console.WriteLine($"A({xA},{yA})");
Console.WriteLine($"B({xB},{yB})");
Console.WriteLine($"C({xC},{yC})");

double Gip(int yA, int yC, int xC, int xB)
{
    int ac;
    int bc;
    int ab2;
    // if (yA > yC) ac = yA - yC;
    ac = yC - yA; 
   // if (xC > xB) bc = xC - xB;
    bc = xB - xC;
    ab2 = (ac * ac) + (bc * bc);
    return Math.Sqrt(ab2);
    // Это же решение:
    // return Math.Sqrt(Math.Pow(ac,2)+ Math.Pow(bc,2));  
}

Console.WriteLine("Расстояние между заданными точками A и B: " + Gip(yA, yC, xC, xB));
