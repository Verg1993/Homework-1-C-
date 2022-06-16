using System;
using static System.Console;

Clear();
Write("Введите число A: ");
int a = Convert.ToInt32(ReadLine());
Write("Введите число B: ");
int b = Convert.ToInt32(ReadLine());

if (a < b)
WriteLine(b);
else
WriteLine(a);
