/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

int number;

Console.WriteLine("Введите пятизначное число");
int.TryParse(Console.ReadLine(), out number);

string numberAsString = number.ToString();
int lengthNumber = numberAsString.Length;

int[] arrayNumbers = new int[lengthNumber];

for (int i = 0; i <lengthNumber ; i++)
{
        arrayNumbers[i] = numberAsString[i];
        
}

bool palindrom = false;
for (int j = 0 ; j < lengthNumber/2 ; j++)
{
        if (arrayNumbers[j] != arrayNumbers[lengthNumber-1-j])
        palindrom = false;
        else if (arrayNumbers[j] == arrayNumbers[lengthNumber-1-j])
        palindrom = true;
}
if (palindrom == true)
        Console.WriteLine("Введенное число является палиндромом");
        
else Console.WriteLine("Введенное число не палиндром");

//получился поиск палиндрома любой длины
