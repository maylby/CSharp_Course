// 13_(С-09) 
// Семинар 9. Рекурсия
// https://gb.ru/lessons/362986

// Задача 1.
// Задать число N. Написать программу, выводящую все натуральные числа от 1 до N.
// N = 5 -> 1, 2, 3, 4, 5
// N = 6 -> 1, 2, 3, 4, 5, 6

// void ShowNumbers(int n)
// {
//     if(n >= 1)
//     {
//         ShowNumbers(n - 1);
//         System.Console.Write(n + " ");
//     }
// }

// Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// ShowNumbers(n);


// Задача 2.
// Программа принимает на вход число и возвращает сумму его цифр.

// int FindSumDigit(int num)
// {
//     if(num > 0) 
//     {
//         return FindSumDigit(num / 10) + num % 10;
//     }
//     else return num;
// }
// Console.Write("Input N: ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.Write($"N = {num} -> sum digit: {FindSumDigit(num)}");


// Задача 3.
// Задать значения M и N. Написать программу, которая
// выводит все натуральные числа в промежутке от M до N.
// M = 1, N = 5 -> 1, 2, 3, 4, 5

// void ShowNumbersGap(int n, int m)
// {
//     if (n != m)
//     {
//         if (n > m)
//         {
//             ShowNumbersGap(n - 1, m);
//             System.Console.Write(n + ", ");
//         }
//         else 
//         {
//             ShowNumbersGap(n, m - 1);
//             System.Console.Write(m + ", ");
//         }
//     }
//     else System.Console.Write(n + ", ");
// }
// Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// ShowNumbersGap(n, m);


// Задача 4.
// Программа принимает на вход 2 числа "А" и "В"
// и возводит число "А" в целую степень "В" с помощью рекурсии.

// int NumToPower(int a, int b)
// {
//     if (b == 0) return 1;
//     return a*Power(a, b - 1);
// }

// Console.Write("Input A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input B: ");
// int b = Convert.ToInt32(Console.ReadLine());

// int result = NumToPower(a, b);
// Console.WriteLine($"{a} to power {b} -> {result}");
