/*
Для перехода к оглавлению используйте git checkout master

Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

int N = 0;
int i = 1;

Console.WriteLine("Введите число ");
int.TryParse(Console.ReadLine(), out N);

if (N == 1 || N == 0) 
{
        Console.WriteLine("Четных чисел нет");
        goto ForcedEnd;
}

Console.WriteLine("Четные числа от 1 до " + N);
while (i <= N)
{
     if ( i % 2 != 1)
    {
            Console.Write(i + ",");
    }
         i++;
}
ForcedEnd:;