// Практичечкая работа 5 по семинару "Функции и одномерные массивы"

// Знакомство с языками программирования (семинары)

// Урок 5. Функции и одномерные массивы

// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// Выводит число чётных элементов массива,
// но, вместо значений массива, 
// показывает "System.Int32[]" по количеству чисел в массиве.

// int[] CreateRandomArray(int size) 
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
// 		if (array[i] > 99 && array[i] < 1000)
//         {
//             array[i] = new Random().Next();
//         }    
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++ )
//     {
//         System.Console.Write(array + " ");
//     }
//     System.Console.WriteLine();
// }  


// int EvenNumberCount(int[] array) 
// {
// 	int count = 0;
// 	for (int i = 0; i < array.Length; i++ )
// 	{
// 		if (array[i]%2 == 0)
// 		{
// 			count++;	
// 		}
// 	}
//     return count;
// }

// System.Console.WriteLine("Imput array size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size);
// PrintArray(myArray);
// System.Console.WriteLine($"{EvenNumberCount(myArray)}");


// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
//     System.Console.WriteLine();
// }

// int SumOddPositions(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 > 0) sum += array[i];
//     }
//     return sum;
// }

// System.Console.Write("Imput array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Imput minimal value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Imput maxsimal value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// PrintArray(myArray);
// System.Console.WriteLine($"{SumOddPositions(myArray)}");


// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// Random.NextDouble() - возвращает дробную часть числа, значение после запятой
// Random.Next() - возвращает целую часть числа от 0 до 9
// Складывая эти методы получим вещественное число (10,001 и пр.)


// Алгоритм 
// поиск минимума и максимума: 
// if (array[i] > max) max = array[i]; // (?)
// if (array[i] < min) min = array[i]; // (?)
// Вычетаем минимум из максимума 
// Печатаем: max - min = diff


// double[] CreateRandomArray(int size, double minValue, double maxValue) 
// {
//     double[] array = new double[size];
//     for (int i = 0; i < size; i++)
//     {
// 	    // if (array[i] > 1) 
// 	    // {
// 		array[i] = new Random().Next(minValue, maxValue +1) + new Random().NextDouble(minValue, maxValue +1);
// 	    // }
// 	    // else
// 	    // {
// 		//     array[i] = new Random().NextDouble(minValue, maxValue +1);
// 	    // }
//     }    
// 	return array;
    
// }

// void PrintArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++ )
//     {
//         System.Console.Write( array[i] + " ");
//     }
//     System.Console.WriteLine(); 
// }

// double DifferenceMinMax(double[] array, double max, double min) // Нужны ли скобки "[]" после "double"? 
// // (?) "void" или "double" // Что означают скобки после типа данных? Содержимое приходит извне?
// {
//     double diff;
//     for (int i = 0; i < array.Length; i++)
//     {
        
//         array[i] = min;
// 	    if (array[i] < min) return min;
//         array[i] = max;
// 	    if (array[i] > max) return max;
//         return array[i];
//     }
//     diff = max - min; 
// }
// // System.Console.WriteLine($"Difference {max} {min} -> {diff}");

// System.Console.WriteLine("Imput array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Imput minimal value: ");
// double minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Imput maxsimal value: ");
// double maxValue = Convert.ToInt32(Console.ReadLine());

// double[] myArray = CreateRandomArray(size, minValue, maxValue);
// PrintArray(myArray);
// System.Console.WriteLine($"{DifferenceMinMax(array, max, min)}");