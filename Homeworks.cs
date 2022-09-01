/*
                            git checkout master - для перехода в оглавление  
        Задачи второго семинара:
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

*/

Console.WriteLine("Введите трехзначное число: ");
int number = 0;
int.TryParse(Console.ReadLine(), out number);

int numberLength = number.ToString().Length;
if (numberLength != 3)
{ 
    Console.WriteLine("Вы ввели не трехзначное число");

}

int[] array = new int[3];
