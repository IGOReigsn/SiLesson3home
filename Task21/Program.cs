/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

string[]coordName={"X","Y","Z"};
double[]koordsA = new double[3];
double[]koordsB = new double[3];// ДВУХМЕРНЫЙ МАССИВ ПОЧЕМУ-ТО НЕ ПОЛУЧИЛСЯ?
Console.WriteLine("Введите координаты первой точки:");
for (int i=0;i<=2;i++)
    {Console.Write("                       "+ coordName[i]+": ");
     koordsA[i]=Convert.ToDouble(Console.ReadLine());
    }
Console.WriteLine("Введите координаты второй точки:");
for (int i=0;i<=2;i++)
    {Console.Write("                       "+ coordName[i]+": ");
     koordsB[i]=Convert.ToDouble(Console.ReadLine());
    }
double result=0;
for (int i=0;i<=2;i++)
    {
        result=result+Math.Pow((koordsB[i]-koordsA[i]),2);
    }
Console.WriteLine("Расстояние между точками:"+ Math.Round(Math.Sqrt(result),2));
