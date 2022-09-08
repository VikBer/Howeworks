/*
git checkout Lesson5task34  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
                                         Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

*/

int[] array = new int [new Random().Next(3,6)];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100,999);
}

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0 ) {count++;}
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
Console.Write($"--> {count} ");