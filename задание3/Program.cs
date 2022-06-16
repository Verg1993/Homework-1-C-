using System;
using static System.Console;

Clear();

Write("Введите число: ");
int a = Convert.ToInt32(ReadLine());

if (a %2 == 0)
WriteLine("Да");
else
WriteLine("Нет");
