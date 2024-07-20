// Семинар 2 "Базовые алгоритмы"

// Задание 1
// Напишите программу, которая будет принимать на вход два числа 
// и выводить, является ли второе число кратным первому. 
// Если второе число не кратно числу первому, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// System.Console.Write("Input three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num>=100 && num<=999)
// {
//     System.Console.WriteLine($"Last digit of {num} -> {num%10}");
// }
// else
// {
//     System.Console.WriteLine("You input not three-digit number");
// }


// Задание 1
// Решение с помощью возвращающего оператора **while**


// System.Console.Write("Input number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());


// while(num1 < num2) // (?) оператор "while" выдаёт результат в виде бесконечной ценпочки  
// {
//     if(num2%num1 == 0)
//     {
//         System.Console.WriteLine($"{num2} -> {num1} - multiple");
//     }
//     else
//     {
//         System.Console.WriteLine($"{num2} -> {num1} - not multiple");
//     }
// }
// while(num1 > num2)
// {
//     if(num1%num2 == 0)
//     {
//         System.Console.WriteLine($"{num1} -> {num2} - multiple");
//     }
//     else
//     {
//         System.Console.WriteLine($"{num1} -> {num2} - not multiple");
//     }
// }



// Задание 1
// Решение с помощью невозвращающего оператора **void**

// void CheckMultiplicity (int num1, int num2)
// {
//     if(num1%num2 == 0)
//     {
//         System.Console.WriteLine($"{num1}, {num2} -> multiple");
//     }
//     else
//     {
//         System.Console.WriteLine($"{num1}, {num2} -> not multiple, remainder: {num1%num2}");
//     }
// }

// System.Console.Write("Input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// CheckMultiplicity(num1, num2);


// Задание 2
// Архип Чижанов 
// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

// 78 -> 8
// 12-> 2
// 85 -> 8

// int FindBiggesDigit(int num)
// {
//     int ed = num%10;
//     int dec = num/10;
//     // int ed = Convert.ToInt32(string[1]);
//     // int dec = Convert.ToInt32(string[0]);
    
//     if(ed > dec)
//     {
//         return ed;
//     }
//     else
//     {
//         return dec;
//     }
// }
// int num = new Random().Next(10, 99 + 1);

// int result = FindBiiggesDigit(num);
// System.Console.Write($"{num} -> {result}");

// System.Console.WriteLine(num);
// System.Console.WriteLine(FindBiiggesDigit(num)); // Вариант команды для получения и вывода результата на экран

// Задача 3 
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98


// void Reduction ()
// {
//     int x = new Random().Next(100, 999 + 1);
//     int num = (x%100 - x%10)/10;
//     int num2 = x - num * 10;
//     System.Console.WriteLine(x);
//     System.Console.Write($"{num} -> {num2}");
// }   
// Reduction ();


// Задача 4 
// (метод "void")
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

// System.Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int a = 7;
// int b = 23;

// void Multiplicity ()
// {
    // if(num%(a*b) == 0) // или так:
    // if (num % a == 0 && num % b == 0);
//     {
//         System.Console.WriteLine($"{num} -> multiple {a}, {b}");
//     }
//     else
//     {
//         System.Console.WriteLine($"{num} -> not multiple {a}, {b}");
//     }
// }
// Multiplicity ();


// Задача 4 
// (метод "bool")

// bool Multiplicity(int num)
// {
//     if (num % 7 == 0 && num % 23 == 0)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }
// System.Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// bool result = Multiplicity(num);
// System.Console.WriteLine(result);