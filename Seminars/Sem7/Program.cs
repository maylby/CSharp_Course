// Семинар 7 Двумернные массивы

// **Задача 46:** /куратор семинара/
// Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.

// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// * Метод создания двумерного массива

// int [,] Creat2DRandomArray(int row, int column, int minValue, int maxValue)
// {
// 	int [,] array = new int[row, column];
// 	// запись элементов, сгенерированных способом "Random().Next()"
// 	for (int i = 0; i < row; i++) // "row" - это "size" строки
// 	{
// 		for (int j = 0; j < column; j++) // "column" - это "size" колонки
// 		{
// 			array[i, j] = new Random().Next(minValue, maxValue +1);
// 		}
// 	}
// 	return array;
// }


// // * Метод вывода на экран двумерного массива

// void Print2DArray(int[,] array)
// {
// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < array.GetLength(1); j++)
// 		{
// 			Console.Write(array[i, j] +" ");		
// 		}
// 		Console.WriteLine(); // перенос на новую строку
// 	}
// }

// Console.WriteLine("Input number of rows: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int column = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximal value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Creat2DRandomArray(row, column, min, max);
// Print2DArray(myArray);


// **Задача 51:** /куратор семинара/
// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Сумма элементов главной диагонали: 1+9+2 = 12

// int[,] Creat2DRandomArray(int row, int column, int minValue, int maxValue)
// {
// 	int [,] array = new int[row, column]; 
// 	for (int i = 0; i < row; i++)
// 	{
// 		for (int j = 0; j < column; j++)
// 		{
// 			array[i, j] = new Random().Next(minValue, maxValue +1);
// 		}
// 	}
// 	return array;
// }

// void Print2DArray(int[,] array)
// {
// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < array.GetLength(1); j++)
// 		{
// 			Console.Write(array[i, j] +" ");		
// 		}
// 		Console.WriteLine(); // перенос на новую строку
// 	}
// }

// int SumOfMainDiagonal(int[,] array)
// {
// 	int sum = 0;
// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{ // скобку можно не ставить, записав "for(j)" под "for(i)" (см. ниже)
// 		for (int j = 0; j < array.GetLength(1); j++)
// 		{
// 			if (i == j) sum += array[i, j];
// 		}
// 	} // эта закрывающая скобка тоже не нужна (см. запись ниже)
// 	return sum;
// }

// // ** Упрощённый вариант записи циклов "for" без фигурных скобок 
// // (проверить в VSCode запись "for(j)" с табуляцией и без)

// //	for (int i = 0; i < row.GetLength(0); i++)
// //		for (int j = 0; j < column.GetLength(1); j++)
// //		{
// //			if (i == j) sum += array[i, j];
// //		}
// //	return sum;

// Console.WriteLine("Input number of rows: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int column = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximal value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Creat2DRandomArray(row, column, min, max);
// Print2DArray(myArray);
// SumOfMainDiagonal(myArray);
// Console.WriteLine(SumOfMainDiagonal(myArray));


// **Задача 48:** 
// (зал /Илья Канаев/)

// Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// !!! - Система сообщает об ошибке в cs(66,12): не удается преобразовать из "int[*,*]" в "int[]"

// void PrintArray(int[] array) // Выводит на экран созданный массив
// {
//     for (int i = 0; i < array.Length; i++ ) // цикл  повторений до завершения
//     {
//         System.Console.Write( array[i] + " "); // содержимое массива
//     }
//     System.Console.WriteLine(); // <- Пустая строка при выводе на экран
// }

// int[,] Create2DArray(int row, int column)
// {
//     int [,] array = new int[row, column];
//     for (int i= 0; i < row; i++)
//     {
//         for (int j = 0; j < column; j++)
//         {
//             array[i,j] = i + j;
//         }
//     }
//     return array;
// }

// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// // Ошибка: Не удается преобразовать из "int[*,*]" в "int[]"
// int[,] myArray = Create2DArray(rows, columns); // cs(65,17), при удалении запятой из "int[] myArray"
// PrintArray(myArray); // cs(66,12), при наличии запятой в скобках "int[,] myArray" 


// **Задача 49:** 
// (зал /Юлия Вознюк/)

// Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

// Например, изначально массив выглядел вот так:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть вот так:

// 1 4 7 2
// 5 **81** 2 **9**
// 8 4 2 4


// using System;
// public class Sem1Task4
// {
//     // error: Программа не содержит статического метода "Main", подходящего для точки входа
//     public static void Main(string[] args) 
//     {
//         Console.WriteLine(); // пустая строка - разрыв текста при выводе на экран
//         Console.Write("Input row: ");
//         int row = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Input columns: ");
//         int columns = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Input min: ");
//         int min = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Input max: ");
//         int max = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine(); // пустая строка - разрыв текста при выводе на экран
//         int[,] myArray = Create2DRandomArray(row, columns, min, max);
//         Console.WriteLine("Start 2d array: ");
//         Print2DArray(myArray);
//         Refill2DArray(myArray);
//         Console.WriteLine(); // пустая строка - разрыв текста при выводе на экран
//         Console.WriteLine("New 2d array: ");
//         Print2DArray(myArray);
//         Console.WriteLine(); // пустая строка - разрыв текста при выводе на экран
//     }
//     public static int[,] Create2DRandomArray(int row, int column, int minValue, int maxValue)
//     {
//         int[,] array = new int[row, column];
//         for (int i = 0; i < row; i++)
//         {
//             for (int j = 0; j < column; j++)
//             {
//                 array[i, j] = new Random().Next(minValue, maxValue);
//             }
//         }
//         return array;
//     }
//     public static void Print2DArray(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//                 {
//                     Console.Write($"{array[i, j]} ");
//                 }
//                 Console.WriteLine();
//         }
//     }
//     public static void Refill2DArray(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 if (i % 2 == 0 && j % 2 == 0)
//                 {
//                     array[i, j] *= array[i, j];
//                 }
//             }
//         }
//     }

// }
