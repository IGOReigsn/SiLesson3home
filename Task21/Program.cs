/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.WriteLine("Введите координаты первой точки:");
Console.Write("                       Х:");
double X1=Convert.ToDouble(Console.ReadLine());
Console.Write("                       Y:");
double Y1=Convert.ToDouble(Console.ReadLine());
Console.Write("                       Z:");
double Z1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки:");
Console.Write("                       Х:");
double X2=Convert.ToDouble(Console.ReadLine());
Console.Write("                       Y:");
double Y2=Convert.ToDouble(Console.ReadLine());
Console.Write("                       Z:");
double Z2=Convert.ToDouble(Console.ReadLine());
double result=Math.Pow(Z2,2);
Console.WriteLine("Расстояние между точками:"+ result);
