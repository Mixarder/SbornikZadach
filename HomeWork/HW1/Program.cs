﻿/* Задача 2: Напишите программу, которая на вход принимает два числа
 и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/ 

Console.Write("Ведите первое число ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Ведите второе число ");
int numB = int.Parse(Console.ReadLine());
if(numA > numB)
{
    Console.WriteLine($"Число {numA} больше, а {numB} меньше");
}
else
{
    Console.WriteLine($"Число {numB} больше, а {numA} меньше");
}