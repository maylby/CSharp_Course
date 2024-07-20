// 13 C#, cеминар 1
// Console.WriteLine("13 C Sharp, cеминнар 1") 
// https://gb.ru/lessons/362978;

// Запись трёх видео роликов семинара 01 на ПК:
// 13_(С-01)_mp4_Препод

// System.Console.WriteLine("Input number: "); // * вывод на экран предложения пользователю
// int num = Convert.ToInt32(System.Console.ReadLine()); // * Считывает с терминала введённую информацию
// // "Console.ReadLine" читает только строку текста,  
// // "Convert.ToInt32" - конвертор для чтения цифр консолью "ReadLine"
// System.Console.WriteLine("Yor number is -> " + num);

// 00:32:10

// Задача 1(зал)
// Напишите программу, которая на вход принимает число и выдаёт его квадрат

// System.Console.Write("Input N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.Write($"Square of the number {num} = {num*num}");

// Видео на странице Семинара 1 на сайте GeekBrains: <https://gb.ru/lessons/362978>
// 00:10:20 (???)

// Задача 2
// Напишите программу, которая на вход принимает два числа
// и проверяет является ли первое квадратом второго

// System.Console.Write("Input number A: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input number B: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 == num2*num2)
// {
//     System.Console.Write($"a = {num1}; b = {num2} -> Yes ");
// }
// else
// {
//     System.Console.Write($"a = {num1}; b = {num2} -> No ");
// }


// Задача 3

// Прогамму, которая принимает на вход одно число (N), 
// на выходе вызывает все числа в промежутке от от -N до N

// 4 -> " -4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> "-2, -1, 0, 1, 2"

// System.Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int count = -n;
// while (count <= n) // Знак "<=" (больше или равно), чтобы захватить посдеднюю цифру промежутка
// {
//     // System.Console.WriteLine(count);
//     // count++; // запись можно упростить, 
//     // поместив "count++" непосредственно в скобки (см. ниже):
//     System.Console.Write(count++ + " ");
// }


// 14:00

// Задача 4
// Напишите программу, кторая на вход принимает трёззначное число, 
// на выходе показывает **последнюю** цифру числа
// 456 -> 6
// 782 -> 2
// 918 -> 8

// System.Console.Write("Input N: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num >= 100 && num <= 999) 
// // Сдвоенный знак "&&" - это "и" (выполнение обоих условий), 
// // знак "||" - это "или" (выполнение хотя бы одного условия)
// {
//     Console.WriteLine($"Last didgit of number {num} -> {num%10}");
// }
// else
// {
//     System.Console.Write("The number is not three-digits");
// }


// 13_(С-01)_mp3_Студенты_Зал-01 //(06:18)
// Задача 3.
// Прогамма на входе принимает число (N) и выдаёт все числа в промежутке от -N до N

// System.Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int index = - num;

// while (index <= num)
// {
// 	System.Console.Write($"{ index}, "); // пиши так -> ($"{ index}, "), будет так -> "-3, -2, -1, 0, 1, 2, 3, "
//     index++;
// }


// Задача 4. // 13_(С-01)_mp3_Студенты_Зал-01 /16:18/
// (Исправленный рабочий код)
// В виде, в котором был применён на семинаре, у меня не запускался

// System.Console.WriteLine("Input three-digit number: "); //"three-digit" - трёхзначный
// int number = Convert.ToInt32(Console.ReadLine());
// if (number >= 100 && number < 1000) // Применять либо "number", либо "num" для одной и той же переменной
// {
// 	Console.Write($"{number} -> {number %10}"); // не делать пробелов между знаками -> ($"{...
// }
// else
// {
// 	Console.WriteLine("Incorrect number entered"); // "Введено не коректное число"
// }