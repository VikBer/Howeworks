/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

string number = "";
Console.Write("Введите число ");
number = Console.ReadLine()!;

int sum = 0;
foreach ( char el in number)
{
    sum += el - 48;
}
Console.WriteLine(sum);