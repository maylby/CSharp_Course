// Семинар 3 "Базовые алгоритмы" (продолжение)


// 08:00
// Задача 1
// Напишите программу, которая, по номеру четверти, показывает 
// диапазон возможных координат точек в данной четверти (x и y)

// void FindCoordinates(int quarter)
// {
// 	if(quarter <= 4 && quarter >= 1)
// 	{
// 		if(quarter == 1)
// 		{
// 			Console.WriteLine("x+ y+");
// 		}
// 		if(quarter == 2)
// 		{
// 			Console.WriteLine("x- y+");
// 		}
// 		if(quarter == 3)
// 		{
// 			Console.WriteLine("x- y-");
// 		}
// 		if(quarter == 4)
// 		{
// 			Console.WriteLine("x+ y-");
// 		}
// 	}
// 	else
// 	{
// 		Console.WriteLine("invalid input: ");
// 	}
// }

// System.Console.Write("Input guarter number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// FindCoordinates(num);


// 00:22:15

// Задача 2
// Написать программу, которая на входе принимает координаты точек и  
// на выходе выдаёт расстояние между ними.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// double FindDistance(double xa, double ya, double xb, double yb)
// {
// 	return Math.Round(Math.Sqrt(Math.Pow(xa - xb ,2) + Math.Pow(ya - yb ,2)), 2);
// 	// Math.Sqrt( ); // метод извлечения корня (квадратного?)
// 	// Math.Pow( ,n) // метод возведения в степень
// 	// Math.Round( ,n); // метод указывает количество знаков после запятой
// }
// // "Convert.ToInt32" - для целых чисел, 
// // "Convert.ToDouble" - для дробей

// System.Console.Write("Input xA coord: ");
// double xa = Convert.ToDouble(Console.ReadLine());
// System.Console.Write("Input yA coord: ");
// double ya = Convert.ToDouble(Console.ReadLine());
// System.Console.Write("Input xB coord: ");
// double xb = Convert.ToDouble(Console.ReadLine());
// System.Console.Write("Input yB coord: ");
// double yb = Convert.ToDouble(Console.ReadLine());

// System.Console.Write($"A({xa}, {ya}); B({xb}, {yb}) -> {FindDistance(xa, ya, xb, yb)}");


// 00:35:50
// Студенты
// Илья Канаев

// Задача 3
// Программа принимает на входе число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25

// void Kvadrats(int n)
// {
// 	int index = 1;
// 	while (index <= n)
// 	{
// 		System.Console.Write($"{index * index}, ");
// 		index++;
// 	}
// }
// // * вариант вывода на экран без "string message":
// // System.Console.Write("Input number: ");
// // int num = Convert.ToInt32(Console.ReadLine());
// // Kvadrats(num);

// int Vvod(string message)
// {
// 	System.Console.Write(message);
// 	int number = Convert.ToInt32(Console.ReadLine());
// 	return number; 
// }
// Kvadrats(Vvod("Введите число: "));


// 00:49:00
// Студенты

// Задача 4
// Напишите программу, которая принимает на вход координаты точки
// (X и Y), причём X=0 и Y=0, и выдаёт номер четверти плоскости,
// в которой находится точка.

int Enter(string message)
{
	System.Console.Write(message);
	int number = Convert.ToInt32(Console.ReadLine());
	return number; 
}

int Quarter(int A, int B)
{
	if(A > 0 && B > 0) return 1;
	if(A < 0 && B > 0) return 2;
	if(A < 0 && B < 0) return 3;
	if(A > 0 && B < 0) return 4;
	else return 0;
}
int x = Enter("Введите координату Х: ");
int y = Enter("Введите координату Y: ");
System.Console.WriteLine(Quarter(x, y));
