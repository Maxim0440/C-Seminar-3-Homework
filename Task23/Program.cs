﻿
// Задача 23: Напишите программу, которая 
// принимает на вход число (N) и выдаёт 
// таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27 
// 5 -> 1, 8, 27, 64, 125


int num = new Random().Next(1,10);
System.Console.WriteLine($"num = {num}");
int i = 1;
while (i <= num)

{
    System.Console.Write (Math.Pow(i, 3));
i++;
}
