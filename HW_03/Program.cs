﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


Console.Write("Введите число: ");
int digit = Convert.ToInt32(Console.ReadLine());

int ostatok = digit % 2;

if(ostatok == 0)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}