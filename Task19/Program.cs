 
// Задача 19: Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли 
// оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да


//int num = new Random().Next(10000,100000);
//System.Console.WriteLine($"num = {num}");

System.Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = num / 10000;
int num2 = num / 1000 - num1 * 10;
int num5 = num % 10;
int num4 = (num % 100 - num5) / 10;


if (num1 == num5 && num2 == num4)

{
    System.Console.Write($"{num} -> да");
}
else if (num > 99999)
{
    System.Console.Write($"{num} -> некорректное число");
}
else if (num < 10000)
{
    System.Console.Write($"{num} -> некорректное число");
}

else
{
    System.Console.Write($"{num} -> нет");
}   
