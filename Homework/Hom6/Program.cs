// Знакомство с языками программирования (семинары)
// Урок 6. Одномерные массивы. Продолжение
// <https://gb.ru/lessons/362983/homework>

// Практическое задание №4

// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

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

// int NumbersGreaterZero(int[] array, int count)
// {
//     for (int i = 0; i < array.Length; i++ )
//     {
//         if (array[i] > 0) count++; 
//     }
//     return count;
//     // Система сообщает, что имена "count" и "array" не существуют в текущем контексте.
// }

// System.Console.WriteLine("Imput array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Imput minimal value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Imput maxsimal value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// PrintArray(myArray);
// myArray = NumbersGreaterZero(myArray); // cs(51,11): Отсутствует аргумент, соответствующий требуемому формальному параметру "count" из "NumbersGreaterZero(int[], int)"
// PrintArray(myArray);
// System.Console.WriteLine(NumbersGreaterZero(array, count));


// * Задача 41 (Пример идеального решения): 

// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int Prompt(string message)
// {
//     System.Console.Write(message);
//     string value = ConsoleReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }



// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// double[] FindPointCross(double k1, double b1, double k2, double b2)
// {
    
//     double x = (b2 - b1)/(k1 - k2);
//     double y = k1*x + b1;
//     double y = k2*x + b2;
// }

// bool CheckLines(double[] line1, double[] line2)
// {
//     if (b1 == b2)
//     {
//         if(k1 == k2)
//         {
//             Console.WriteLine("Прямые совпадают");
//             return false;
//         }
//         else
//         {
//             Console.WriteLine("Прямые параллельны");
//             return false; 
//         }
//     }
//     return true;
// }

// System.Console.Write("Input value b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// System.Console.Write("Input value k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// System.Console.Write("Input value b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// System.Console.Write("Input value k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());

// double myLine = FindPointCross(k1, b1, k2, b2);
// CheckLines(myLine);
// System.Console.Write($"({b1}, {k1}); ({b2}, {k2}) -> {FindPointCross(line1, line2)}");

