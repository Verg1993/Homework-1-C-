using System;
using static System.Console;

Clear();
Write("Введите число А: ");
int a = Convert.ToInt32(ReadLine());
Write("Введите число B: ");
int b = Convert.ToInt32(ReadLine());
Write("Введите число С: ");
int c = Convert.ToInt32(ReadLine());

if ((a > b) && (a > c))
WriteLine(a);
if ((b > a) && (b > c))
WriteLine(b);
if ((c > a) && (c > b))
WriteLine(c);
