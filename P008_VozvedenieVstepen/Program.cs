﻿
//Является ли a квадратом b. Возведение в степень.





Console.Write("a:");
int a = int.Parse(Console.ReadLine());
Console.Write("b:");
int b = int.Parse(Console.ReadLine());
if(Math.Pow(b,2) == a){
    Console.WriteLine("а квадрат b");
}else{
    Console.WriteLine("а не квадрат b");
}
Console.WriteLine($"{Math.Pow(b,2) == a}");