﻿//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1 = new Random().Next(0,3);
Console.WriteLine($"Переменная b1 равна {b1}");
double b2 = new Random().Next(0,5);
Console.WriteLine($"Переменная b2 равна {b2}");
double k1 = new Random().Next(0,4);
Console.WriteLine($"Переменная k1 равна {k1}");
double k2 = new Random().Next(0,5);
Console.WriteLine($"Переменная k2 равна {k2}");

double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");

  
  
  
  




