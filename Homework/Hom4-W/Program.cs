// Домашнее задание по семинару 4 

// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Power(int powerBase, int exponent)
// {
//     int power = 1;
//     for (int i = 0; i < exponent; i++)
//     {
//         power *= powerBase; // power = power * powerBase
//     }
//     return power;
// }

// bool ErrorExpo(int exponent)
// {
// 	if (exponent < 0)
// 	{
// 		Console.WriteLine("Показатель степени не должен быть меньше нуля");
// 		return false; 
// 	}
// 	return true;
// }

// void PrintPower(int[] powerBase, int[] exponent, int[] power)
// {
//     for (int i = 0; i < exponent; i++ )
//     {
//         Console.Write($"{powerBase}, {exponent} -> {power}");
//     }
// }

// System.Console.WriteLine("Введите значение основания: ");
// int powerBase = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите значение показателя: ");
// int exponent = Convert.ToInt32(Console.ReadLine());

// int[] myPower = Power(powerBase, exponent);
// PrintPower(myPower);


// Задача 27: 
// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12 

// int DigitSum(int num)
// {
//     int sum = 0;
//     // while (num > 0) 
//     while (Math.Abs(num) > 0) // "Math.Abs(num)" - число по модулю (положительное и отрицательное)
//     {
//         sum += num % 10; // <- sum = sum + num%10; 
//         num = num / 10;
//     }
//     return sum;
// }
// System.Console.WriteLine("Imput number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.Write($"{DigitSum(num)}");

