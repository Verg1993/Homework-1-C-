using System;
using static System.Console;
Clear();

Write("Введите число N: ");
int N = Convert.ToInt32(ReadLine());
int current = N-(N-1);

while (current <= N)
{ 
    if( current %2 == 0)
    Write(current);
    Write(", ");
    current++;
}


