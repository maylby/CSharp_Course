﻿// # Домашнее задание 1

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// System.Console.Write("first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int a = num1;
// int b = num2;

// if (a < b)
// {
// 	Console.Write($"max: {b}");
// }
// else
// {
// 	Console.Write($"max: {a}");
// }

// Задача 4: 
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// System.Console.Write("first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("thired number: ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int max = num1;

// if (num2 > max)
// {
// 	max = num2;
// 	if (num3 > max)
// 	{
// 		max = num3;
// 	}
// 	System.Console.Write($"max number: {max}");
// }

// Задача 6: 
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


// Console.Write("number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number %2 == 0) // Остаток от деления на 2 равен нулю. 
// {
// 	Console.Write($"{number} - even number");
// }
// else
// {
// 	Console.Write($"{number} - not even number");
// }

// Задача 8: 
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// System.Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int size = num+1;
// int index = 1;

// while (index < size)
// {
//     if (index%2 == 0)
//     {
//         System.Console.Write($"{ index}, ");  
//     }
//     index++;   
// }

// Задача 8+ (... на выходе показать все **нечётные** числа) 

// System.Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int size = num+1;
// int index = 1;

// while (index < size)
// {
//     if (index%2 < 0) // Не работает, нечётные числа не показывает, выдаёт введённое число
//     {
//         System.Console.Write($"{ index}, ");  
//     }
//     index++;   
// }