// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
//
// Console.WriteLine("Введите число А");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a > b)
// {
// Console.WriteLine($"{a} > {b}");
// }
// if (b > a)
// {
// Console.WriteLine($"{b} > {a}");
// }
// else
// {
// Console.WriteLine($"{b} = {a}");
// }
// ////////////////////////////
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Console.WriteLine("Введите число А");

// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число C");
// int c = Convert.ToInt32(Console.ReadLine());
// _ = Console.ReadLine();
// int Max = Convert.ToInt32(Console.ReadLine());
// if (a > b) 
// {
//     a = Max;
// }
// else 
// {
//     b = Max;
// }
// if (b > c)
// {
//     b = Max;
// }
// else 
// {
//     c = Max;
// }
// if (c > a)
// {
//     c = Max;
// }
// else 
// {
//     a = Max;
// }
// {
// Console.WriteLine(Max);
// }
// ////////////////////////////////
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).


// Console.WriteLine("Введите число А");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a % 2 == 0)
// {
// Console.WriteLine($"Да число {a} четное");
// }
// else
// {
// Console.WriteLine($"Нет число {a} не четное");
// }
// ////////////////////////////////
// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// Console.WriteLine("Введите число");

// int N = int.Parse(Console.ReadLine()!);
// int k = -N;
// while(k<=N)
// if k % 2 == 0
// {
// Console.Write($"{k} ");
// k++;