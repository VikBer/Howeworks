/*

Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76

*/

double [] array = new double [new Random().Next(4,9)];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,100);
}

double maxNumber = array[0];
double minNumber = array[0];

  for (int i = 1; i < array.Length; i++)
  {
    if (maxNumber < array[i])
    {
      maxNumber = array[i];
    }
        if (minNumber > array[i])
    {
      minNumber = array[i];
    }
  }

  double result = maxNumber - minNumber;


for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");

Console.WriteLine($"\nразница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {result}");
