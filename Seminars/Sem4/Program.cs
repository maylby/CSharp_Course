// Семинар 4 "Функции"

// 0:19:00
// Задача 1
// Напишите программу, которая принимает на вход число
// и выдаёт количество цифр в числе

// int DigitCount (int num)
// {
//     int count = 1;
//     while (num > 10)
//    // while (Math.Abs(num) > 10) // "(Math.Abs(num)" - число по модулю (положительное и отрицательное)
//     {
//         num = num / 10;
//         count++;
//     }
//     return count;
// }
// System.Console.WriteLine("Imput number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(DigitCount(num));

// Задача 2
// Архип Чижанов 
// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

// Универсальный метод заполнения массива на основе предложенной задачи

// int[] CreateRandomArray(int size, int minValue, int maxValue) 
// // Cкобки "[]" перед именем метода сообщают, что метод возвращает массив 
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

// // System.Console.WriteLine(CreateRandomArray(size, min, max)); // Данная конструкция не работает
// int[] myArray = CreateRandomArray(size, min, max);
// PrintArray(myArray);


// 00:58:00
// Студенты

// Задача 3
// Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.

// 7 -> 28
// 4 -> 10
// 8 -> 36

// int Prompt(string message)
// {
//     Console.WriteLine(message);
//     int prompt = Convert.ToInt32(Console.ReadLine());
//     return prompt;
// }

// int Numbers(int A)
// {
//     int sum = 0;
//     for (int i = 1; i <= A; i++)
//     {
//         sum = sum += i;
//     }
//     return sum;
// }
// // System.Console.Write("Input A: "); // Реализация ввода без "Prompt(string message)"
// // int A = Convert.ToInt32(Console.ReadLine());
// // System.Console.WriteLine(Number (A)); // Вывод, если нет строки ввода "Prompt(string message)"

// int A = Prompt("Imput A: "); // Ввод при наличии строки ввода "Prompt(string message)"
// Console.WriteLine(Numbers(A)); // Вывод для "Prompt(string message)" - строка ввода



// Задача 4.
// Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120

// int Prompt(string message)
// {
//     Console.WriteLine(message);
//     int prompt = Convert.ToInt32(Console.ReadLine());
//     return prompt;
// }

// int Factorial(int num)
// {
//     int factorial = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         factorial *= i; // factorial = factorial * i;
//     }
//     return factorial;
// }

// System.Console.Write("Input number: "); // Ввод, если нет строки ввода "Prompt(string message)"
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Factorial(num)); // Вывод, если нет "Prompt(string message)"

// int num = Prompt("Imput number: "); // Ввод при наличии строки ввода "Prompt(string message)"
// Console.WriteLine(Factorial(num)); // Вывод со строкой ввода "Prompt(string message)"

