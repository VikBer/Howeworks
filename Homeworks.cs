/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int arraySize = 3;

int[] arrayA = new int[arraySize];
int[] arrayB = new int[arraySize];

double distanceBetween;

void FillArray(int[] arr)
{
    for (int i = 0; i < arraySize; i++)
    {
        Console.WriteLine($"Введите {i + 1} координату точки: ");
        arr[i] = int.Parse(Console.ReadLine()!);
    }
    return;
}

Console.WriteLine("Для точки А:");
FillArray(arrayA);

Console.WriteLine("Для точки B:");
FillArray(arrayB);

distanceBetween = Math.Round
        (
        Math.Sqrt
                (
                Math.Pow((arrayB[0] - arrayA[0]), 2)
                + Math.Pow((arrayB[1] - arrayA[1]), 2)
                + Math.Pow((arrayB[2] - arrayA[2]), 2)
                )
        , 2
        );
Console.WriteLine($"Расстояние между двумя точками = {distanceBetween}");