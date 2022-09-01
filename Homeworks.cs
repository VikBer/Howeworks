/*

git checkout Lesson2task13  Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
                                        что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6

*/

int N;

Console.WriteLine("Введите любое число");
int.TryParse(Console.ReadLine(), out N);
string numberInString = N.ToString();
int numberLength = numberInString.Length;

if (numberLength<3) {Console.WriteLine("Третьей цифры нет");}
else  {Console.WriteLine( numberInString[2]);}