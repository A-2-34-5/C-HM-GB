﻿// //Напишите программу, которая выводит случайное число из отрезка [10, 99] // и показывает наибольшую цифру числа.
// Console.Clear();

// int num = new Random().Next(10, 100);
// // 12 / 10 = 1; 12 % 10 = 2
// int a1 = num / 10;
// int a2 = num % 10;

// int max = a1;
// if (max < a2)
// {
// max = a2;
// }

// Console.WriteLine($"Максимальная цифра числа {num} равна {max}");
// //////////////////////////////////////////////////////
// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// Console.Clear();

// int a = new Random().Next(100, 1000);

// Console.WriteLine($"Рандомное число: {a}");
// Console.WriteLine($"Получилось число: {a / 100 * 10 + a % 10}");
// //////////////////////////////////////////////////////////
// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// Console.Clear();
// int first = new Random().Next(1,100);
// int second = new Random().Next(1,100);
// int ost = first % second;
// if (ost == 0) Console.WriteLine($"Число {first} кратное {second}");
// else Console.WriteLine($"Остаток от деления {ost}");
// ///////////////////////////////////////////////////////
// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// Console.Clear();

// Console.Write("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int num2 = int.Parse(Console.ReadLine()!);

// if (num1 == num2 * num2 || num2 == num1 * num1) Console.WriteLine("Да");
// else Console.WriteLine("Нет");