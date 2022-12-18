/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

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
            numArr2D [i, j] = new Random ().Next (0, 10); // заполняем массив 
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

double [] FindAvrArr (int [,] array2D)
{
    double [] avrArr = new double [array2D.GetLength (1)];
    for (int i = 0; i < array2D.GetLength (1); i++)
    {
        for (int j = 0; j < array2D.GetLength (0); j++)
        {
            avrArr [i] += array2D [j, i];
        }
        avrArr [i] = avrArr [i] / array2D.GetLength (0);
    }
    return avrArr;
};

void PrintArray (double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = Math.Round (array [i], 1);
        Console.Write (array [i] + " ");
    }
        Console.WriteLine ();
}

int m = InputNum ("Enter the number of lines: ");
int n = InputNum ("Enter number of columns: ");

int [,] array2D = SetArray2DInt (m, n);

PrintArray2DInt (array2D);

double [] arrayAvr = FindAvrArr (array2D);

Console.WriteLine ($"Arithmetic mean of column elements:");
PrintArray (arrayAvr);