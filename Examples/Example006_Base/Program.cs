﻿// Знакомство с языками программирования (лекции)
// Урок 1. Знакомство с языком программирования C#
// https://gb.ru/lessons/362970#s951

// Поиск максимального элемента

int a = 1;
int b = 2;
int c = 36;
int d = 8;
int e = 4;

int max = a; // значение первого элемента
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);