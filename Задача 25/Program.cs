﻿/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int A;
int B;
int sum = 1;
Console.WriteLine("Введите возводимое в степень число: ");
int.TryParse(Console.ReadLine(), out A);
Console.WriteLine("Введите степень для числа A: ");
int.TryParse(Console.ReadLine(), out B);
Console.Write($"{A} в степени {B} = ");
        for (int i = 1; i <= B; i++)
    {
       sum = sum * A;
    }
 Console.Write($"{sum}");

