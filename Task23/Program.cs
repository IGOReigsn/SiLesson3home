/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.WriteLine("Введите число:");
double num=Convert.ToDouble(Console.ReadLine());
if (num>0)
    {for(double i=1;i<=num;i++)
        {Console.Write( i + " => "+ Math.Pow(i,3)+ "    ");}
    }
else {Console.Write("Введенное число должно быть положительным ");}
Console.WriteLine();