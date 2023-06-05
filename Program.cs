// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

/*
double [,] Create2dArray()// Создание двумерного массива
{
    Console.WriteLine("Input count of row");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input count of columns");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input minimum");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input maximum");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    double [,] created2dArray=new double [rows,columns];
    for (int i = 0; i < rows; i ++)
        for (int j=0;j<columns; j++)
        {
            created2dArray[i,j] = Math.Round(new Random().Next(minVal,maxVal+1)+new Random().NextDouble(),1);
        
        }
    return created2dArray;
}


void Print2Array(double [,] array2d)  //  Вывод массива на экран
{
    for (int i=0; i<array2d.GetLength(0);i++)
    {
        for (int j=0;j<array2d.GetLength(1);j++)
        {
            Console.Write (array2d[i,j] + " ");
        }
      
        Console.WriteLine();
    }
    Console.WriteLine();
}

double [,] new2dArray=Create2dArray();
Print2Array(new2dArray);

*/

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4
17 -> такого числа в массиве нет
*/
/*

int [,] Create2dArray()// Создание двумерного массива
{
    Console.WriteLine("Input count of rows new array");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input count of columns new array");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input minimum");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input maximum");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int [,]created2dArray=new int [rows,columns];
    for (int i = 0; i < rows; i ++)
        for (int j=0;j<columns; j++)
        {
            created2dArray[i,j] = new Random().Next(minVal,maxVal+1);
        
        }
    return created2dArray;
}

void Print2Array(int [,] array2d)
{
    for (int i=0; i<array2d.GetLength(0);i++)
    {
        for (int j=0;j<array2d.GetLength(1);j++)
        {
            Console.Write (array2d[i,j] + " ");
        }
      
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ElementFound(int [,] array, int row, int col) // Поиск элемента массива или вывода сообщения об отсутствии элемента массива
{
    if(row < array.GetLength(0) && col < array.GetLength(1))
    {
        int elem = array [row,col];
        Console.WriteLine($"Element value: {elem}");
    }
    else
    Console.WriteLine("no such element");

}

int [,] new2dArray=Create2dArray();
Print2Array(new2dArray);

Console.WriteLine("Input of row");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input of column");
int column = Convert.ToInt32(Console.ReadLine());
ElementFound(new2dArray,row,column);

*/

/*


Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int [,] Create2dArray()// Создание двумерного массива
{
    Console.WriteLine("Input count of row");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input count of columns");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input minimum");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input maximum");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int [,] created2dArray = new int [rows,columns];
    for (int i = 0; i < rows; i ++)
        for (int j=0;j<columns; j++)
        {
            created2dArray[i,j] = new Random().Next(minVal,maxVal+1);
        }
    return created2dArray;
}


void Print2Array(int [,] array2d)  //  Вывод массива на экран
{
    for (int i=0; i<array2d.GetLength(0);i++)
    {
        for (int j=0;j<array2d.GetLength(1);j++)
        {
            Console.Write (array2d[i,j] + " ");
        }
      
        Console.WriteLine();
    }
    Console.WriteLine();
}

void  AverageColElem (int [,] array)
{
    double sum = 0;
    double average;
    for (int j = 0; j<array.GetLength(1);j++)
    
    {
        for (int i = 0; i<array.GetLength(0); i++)
        {
            sum = sum + array[i,j];
        }
        
        average = sum/array.GetLength(0);
        Console.Write($"{average} ");
        sum = 0;
    }
    
}
int [,] new2dArray=Create2dArray();
Print2Array(new2dArray);
AverageColElem(new2dArray);

