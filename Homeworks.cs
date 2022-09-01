/*

 git checkout Lesson2task15  Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
                                         и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

*/

Console.Write("введите номер дня недели ");
int a = int.Parse(Console.ReadLine()!);
if ( a == 6 || a == 7) Console.WriteLine("выходной!");
else if (a<1 || a>7) Console.WriteLine("некорректно введен номер дня недели");
else if ( a<7 || a>0) Console.WriteLine("увы, рабочий день");