﻿// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите число = ");
int num = Convert.ToInt32(Console.ReadLine());
int summ = 0;
for (int i = 1; i <= num; i++)
{
    summ = summ + i;
    }
Console.WriteLine($"Сумма чисел = {summ}");
