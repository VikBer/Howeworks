/*
                            git checkout master - для перехода в оглавление  
        Задачи второго семинара:
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

*/

int number = 0;

Console.WriteLine("Введите трехзначное число: ");

int.TryParse(Console.ReadLine(), out number);
int numberLength = number.ToString().Length;

while (numberLength != 3)
{
    Console.WriteLine("Вы ввели не трехзначное число \n Введите трехзначное число");
    int.TryParse(Console.ReadLine(), out number);
    numberLength = number.ToString().Length;
}
Console.WriteLine($"Второче число {number/10%10}");
