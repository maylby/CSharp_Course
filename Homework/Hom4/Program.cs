// Домашнее задание по семинару 4

// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// // // * Вариант 1, решение со "string message", как в примере к ДЗ
// // // ** Начало кода

// // int Enter(string message)
// // {
// //     System.Console.Write(message);
// //     string readImput = System.Console.ReadLine();
// //     int result = int.Parse(readImput);
// //     return result;
// // }

// // // * Вариант 2, решения с "Convert.ToInt32"
// // // ** Начало кода

// int Power(int basis, int exponent)
// {
// 	int power = 1;
// 	for (int i = 0; i < exponent; i++)
// 	{
// 		power *= basis; // либо -> power = power * basis;
// 	}
// 	return power;
// }

// bool ErrorExponent(int exponent)
// {
//     if (exponent < 0)
//     {
// 		Console.WriteLine("Экспонент - не меньше нуля");
//         return false;
//     }
//     return true;
// }

// // // ** Консоль "Вход/Выход" для Варианта 2 ("Convert.ToInt32"):

// Console.Write("Введите основание: ");
// int basis = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите экспонен: ");
// int exponent = Convert.ToInt32(Console.ReadLine());
// int myPower = Power(basis, exponent);
// ErrorExponent(myPower);
// Console.WriteLine($"{basis}, {exponent} -> {Power(basis, exponent)}");

// // // ** Консоль "Вход/Выход" для Варианта 1 ("string message"):

// // int basis = Enter("Введите основание: ");
// // int exponent = Enter("Введите экспонен: ");
// // if (ErrorExponent(exponent))
// // {
// //     Console.WriteLine($"{basis}, {exponent} -> {Power(basis, exponent)}");
// // }



// * Код Задачи 25 из "примера идеального решения"

// using System.Xml.XPath;

// int Prompt(string messege)
// {
//     Console.Write(messege);
//     string readImput = Console.ReadLine();
//     int result = int.Parse(readImput);
//     return result;
// }

// int Power(int powerBase, int exponent)
// {
//     int power = 1;
//     for (int i = 0; i < exponent; i++)
//     {
//         power *= powerBase;
//     }
//     return result;
// }

// bool ValidateExponente(int exponent)
// {
//     if (exponent < 0)
//     {
//         Console.WriteLine("Показатель не должен быть меньше нуля");
//         return false;
//     }
//     return true;
// }

// int powerBase = Prompt("Введите основание: ");
// int exponent = Prompt("Введите показатель: ");

// if (ValidateExponente(int exponent))
// {
//     Console.WriteLine($"Число {powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
// }
// // !!!- "Error: Программа не содержит статического метода "Main", подходящего для точки входа."



// Задача 27: 
// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12 

// int DigitSum(int num)
// {
//     int sum = 0;
//     while (Math.Abs(num) > 0)
//     {
//         sum += num % 10;  
//         num = num / 10;
//     }
//     return sum;
// }
// System.Console.WriteLine("Imput number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.Write($"{DigitSum(num)}");


// Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] CreateRandomArray(int size, int minValue, int maxValue) 
// {
//     int[] array = new int[size]; 
//     for (int i = 0; i < size; i++) 
//     {
//         array[i] = new Random().Next(minValue, maxValue +1); 
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++ )
//     {
//         System.Console.Write( array[i] + " ");
//     }
// }

// System.Console.WriteLine("Imput array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Imput minimal value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Imput maxsimal value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// PrintArray(myArray);



// Задача 1 из семинара 4 (Архип Чижанов)
// Напишите программу, которая принимает на вход число
// и выдаёт количество цифр в числе


// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write( array[i] + " " );
//     }
// }

// System.Console.WriteLine("Input array size: " );
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value: " );
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value: " );
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// PrintArray(myArray);