/*
Для перехода в оглавление, вернитесь в ветку master  - git checkout master

 Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 

*/

double a = 0, b = 0, c = 0, max = 0;

Console.WriteLine("Введите первое число");
double.TryParse(Console.ReadLine(), out a);

Console.WriteLine("Введите второе число");
double.TryParse(Console.ReadLine(), out b);

Console.WriteLine("Введите третье число");
double.TryParse(Console.ReadLine(), out c);

if (a > b && a > c)
    max = a;
else if (b > a && b > c)
    max = b;
else max = c;

Console.Write($"max = {max}");