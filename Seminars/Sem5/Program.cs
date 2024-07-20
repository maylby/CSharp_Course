// Семинар 5. 
// Функции и одномерные массивы

// 00:12:50

// Задача 1 
// (разбор)

// Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

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
//     // Пустая строка в блоке вывода на экран, создана для удобства чтения 
//     // двойной строки в "FindMinMaxSum", при выводе даннгой строки на экран 
// }

// void FindMinMaxSum(int[] array)
// {
//     int positivSum = 0;
//     int negativSum = 0;
//     for (int i = 0; i < array.Length; i++ )
//     {
//         if (array[i] > 0)
//         {
//             positivSum += array[i]; // <- Краткая запись: "positivSum = positivSum + arrau[i]"
//         }
//         else
//         {
//             negativSum += array[i];
//         }
//     }
//     System.Console.WriteLine($"Sum of positivSum arrau elements -> {positivSum} \nSum of negativSum arrau elements -> {negativSum}");

//     // Для компактности записи, чтобы видеть всю строку кода, её делят на части:
//     // Значок "\n" разделяет две разных записи в одной строке, а
//     // значок "+" (плюс) связывает текст в единый блок, 
//     // добавляя перенесённый кусок к предыдущей записи.
//     // Выше приведенную конструкцию ("Console.WriteLine"), в VSCode,
//     // не удалось разделить на части и перенести на другую строку описанным способом. 
//     // Две записи удалось разделить, только поместив каждую в отдельную команду, 
//     // в конструкции "System.Console.WriteLine($"... -> {}");"
//     // Для примера оформления, оставил запись в одну строку.
// }

// System.Console.WriteLine("Imput array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Imput minimal value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Imput maxsimal value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max); // Передача значений в "myArray" для компактности 
// PrintArray(myArray); // Вызов метода вывода на экран данных, переданных в "myArray" строкой выше 
// FindMinMaxSum(myArray); // передача методу данных "myArray" для обработки и вывода на экран 


// 00:25:30

// Задача 2 
// (№4 - из презентации семинара).

// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99].

// Универсальный код для создания произвольного массива пользователем.

// int[] CreateRandomArray(int size, int minValue, int maxValue) 
// // "size" - количество элементов массива, 
// // "minValue" и "maxValue" - минимальное и максимальное значение
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
//     System.Console.WriteLine(); // <- Пустая строка - пропуск в блоке вывода результата на экран
// }

// int QuantityInTheSegments(int min, int max, int[] array) // <- название массива произвольно, но передаёт принцип его работы 
// //  "int max" и "int min" - границы промежутка, которые будут запрашиваться у пользователя
// // "int[] array" - указание на то, что методу будет передаваться массив ("[]")
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] <= max && array[i] >= min)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// System.Console.WriteLine("Imput array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Imput minimal value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Imput maximal value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Imput lower border value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Imput upper border value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// PrintArray(myArray); 
// // Метод "void PrintArray" (невозвращающий) не может передать данные в "Console.WriteLine();"
// // System.Console.WriteLine(QuantityInTheSegments(min, max, myArray)); 
// // Метод "int QuantityInTheSegments" (возвращающий) может передать данные в "Console.Write();"

// // QuantityInTheSegments(max, min, myArray); // <- так можно обратиться, только к методу "void"
// // подобное обращение не выводит на экран значение "count", количество чисел из заданного промежутка,
// // так как "count" вычислялся именно этим методом, а его значения не переданы для вывода.
// // Чтобы это исправить, следует, либо создать переменную, передав ей данные метода, 
// // и уже саму переменную передать в "Console.WriteLine",
// // либо прямо передать метод "QuantityInTheSegments(...)" сразу в "Console.WriteLine" (см. ниже)

// System.Console.WriteLine(QuantityInTheSegments(min, max, myArray));
// // "max, min" - данные, переданные пользователем в "QuantityInTheSegments"
// // "myArray" - массив, сформированный в "CreateRandomArray" и переданный в "QuantityInTheSegments"


// 00:40:30

// Задача 3.1
// Задайте массив. 
// Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

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
//     System.Console.WriteLine(); // <- Пустая строка - пропуск в блоке вывода результата на экран
// }

// bool ExistenceInArray(int num, int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == num) return true;
//     }
//     return false;
// }

// System.Console.WriteLine("Imput array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Imput minimal value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Imput maximal value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Imput number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// PrintArray(myArray);
// // // System.Console.WriteLine(RequiredNumber(num, myArray));
// // // // RequiredNumber(num, myArray);
// // // // System.Console.WriteLine($"Yes, {num} -> in the array"); // разделить вывод ответов "No" и "Yes"
// // // // System.Console.WriteLine($"No {num} -> in the array");
// System.Console.WriteLine(ExistenceInArray(num, myArray));


// 00:53:00

// Задача 3.2
// Создайте массив. 
// Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

// (Ручной ввод чисел массива, вместо "Random")

// int[] CreateUserArray(int size) 
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write("Imput element array: " );
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++ )
//     {
//         System.Console.Write( array[i] + " ");
//     }
//     System.Console.WriteLine(); // <- Пропуск в блоке вывода результата на экран
// }

// bool ExistenceInArray(int num, int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == num) return true;
//     }
//     return false;
// }

// System.Console.Write("Imput array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Imput number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateUserArray(size);
// PrintArray(myArray);
// System.Console.WriteLine(ExistenceInArray(num, myArray));


// 00:57:50
// (Илья Канаев) 

// Задача 2 
// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

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
// int[] ChangeElements(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1; // array[i] = array[i] * (-1);
//     }
//     return array;
// }

// System.Console.Write("Imput array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Imput minimal value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Imput maximal value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// PrintArray(myArray);
// PrintArray(ChangeElements(myArray));

