﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int digit = Convert.ToInt32(Console.ReadLine());

int evenNumber = 2;

if(digit > 1)
{
    while(evenNumber <= digit)
    {
        Console.Write(evenNumber + " ");
        evenNumber = evenNumber + 2;
    }
}