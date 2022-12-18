/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

int InputNum (string message)
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
}

int [,] SetArray2DInt (int line, int column)
{
    int [,] numArr2D = new int [line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            numArr2D [i, j] = new Random ().Next (0, 100);  
        }
    }
    return numArr2D;
}

void PrintArray2DInt (int [,] array2D)
{
    for (int i = 0; i < array2D.GetLength (0); i++)
    {
        for (int j = 0; j < array2D.GetLength (1); j++)
        {
            Console.Write (array2D [i, j] + " ");
        }
        Console.WriteLine ();
    }
}

int [] FindInx (int number)
{
    int [] idxArr = new int [2];
    idxArr [0] = number / 10;
    idxArr [1] = number % 10;
    return idxArr;
}

void PrintUnitArr (int [,] array2D, int [] array)
{
    if (array [0] > array2D.GetLength (0) || array [1] > array2D.GetLength (1))
    {
        Console.WriteLine ($"There is no such element in the array, line {array [0]} column {array [1]}");
    }
    else
    {
        Console.WriteLine ($"Ваш элемент: {array2D [array[0] - 1, array [1] - 1]}");
    }
}

int m = InputNum ("Set the number of rows: ");
int n = InputNum ("Set the number of columns: ");

int [,] array = SetArray2DInt (m, n);

Console.WriteLine ($"Your array {m}x{n}:");
PrintArray2DInt (array);

int num = InputNum ("Enter a two-digit cell index: ");
int [] index = FindInx (num);

PrintUnitArr (array, index);