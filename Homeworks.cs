// Для перехода на другие ветки вернитесь в оглавнение -  git checkout master
/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

double a = 0, b = 0, max = 0;

Console.WriteLine("Введите первое число");
double.TryParse(Console.ReadLine(), out a);

Console.WriteLine("Введите второе число");
double.TryParse(Console.ReadLine(), out b);

if (a < b)
    max = a;
max = b;

Console.Write($"max = {max}");
// а как сделать сравнение для отрицательных чисел? Нужна логика.