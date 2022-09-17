﻿// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

string GetNaturalsBetweenWithRecursion(int m, int n)
{
if (m == n) return Convert.ToString(n);
return m + ", " + GetNaturalsBetweenWithRecursion(m + 1, n);
}

System.Console.Write(GetNaturalsBetweenWithRecursion(1, 5));