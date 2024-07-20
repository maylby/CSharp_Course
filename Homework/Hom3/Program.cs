// Задача 1

// Палиндром

// Инструкция по использованию платформы

// Внутри класса Answer напишите метод IsPalindrome, 
// который принимает на вход пятизначное число number 
// и проверяет, является ли оно палиндромом.

// Метод должен проверить является ли число пятизначным, 
// в противном случае - вывести "Число не пятизначное" 
// и "False" в следующей строке.

// Для остальных чисел вернуть "True" или "False".

// 14212 -> False
// 12821 -> True
// 234322 -> Число не пятизначное
//                      False


// using System;

// public class Answer
// {
//     static bool IsPalindrome(int number)
//     {
//       // Введите свое решение ниже
      
//     }
  
//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) 
//     {
//         int number;

//         if (args.Length >= 1) 
//         {
//             number = int.Parse(args[0]);
//         } 
//         else 
//         {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 64546;
//         }

//         // Не удаляйте строки ниже
//         bool result = IsPalindrome(number);
//         System.Console.WriteLine($"{result}");
//     }
// }


// Задача 2
// 3D пространство

// Инструкция по использованию платформы

// Внутри класса Answer напишите метод DistanceBetweenPoints, 
// который принимает на вход координаты двух точек pointA и pointB в виде массива целых чисел, 
// и возвращает расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// using System;

// public class Answer
// {
//     private static double Length(int[] pointA, int[] pointB)
//     {
//       // Введите свое решение ниже

      

//     }

//   // Не удаляйте и не меняйте метод Main! 
//     public static void Main(string[] args) 
//     {
//         int x1, x2, x3, y1, y2, y3;

//         if (args.Length >= 6) {
//             x1 = int.Parse(args[0]);
//             x2 = int.Parse(args[1]);
//             x3 = int.Parse(args[2]);
//             y1 = int.Parse(args[3]);
//             y2 = int.Parse(args[4]);
//             y3 = int.Parse(args[5]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             x1 = 3;
//             x2 = 6;
//             x3 = 8;
//             y1 = 2;
//             y2 = 1;
//             y3 = -7;
//         }

//         // Не удаляйте строки ниже
//         double result = Length(new int[]{x1, x2, x3}, new int[]{y1, y2, y3});
//         Console.WriteLine($"{result:F2}");
//     }
// }


// Таблица кубов

// Инструкция по использованию платформы

// Внутри класса Answer напишите метод ShowCube, 
// который принимает на вход число (N) 
// и выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.

// using System;

// public class Answer
// {
//    static void ShowCube(int N)
//     {
//       // Введите свое решение ниже
//         int index = 1;
// 	    while (index <= N)
// 	    {
// 		    System.Console.WriteLine($"{index * index * index} ");
// 		    index++;
// 	    } 
//     }

//   // Не удаляйте и не меняйте метод Main! 
//       static public void Main(string[] args) {
//         int N;

//         if (args.Length >= 1) {
//             N = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             N = 5;
//         }

//         // Не удаляйте строки ниже
//         ShowCube(N);
//     }
// }