/* Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

void ShowNewMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,3}", array[i, j]);
        }
        Console.WriteLine();
    }
}

void SortingMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(1) - 1; k++)
                if (array[i, k] < array[i, k + 1])
                {
                    int bufer = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = bufer;
                }
}

int[,] GenerateMatrix(int rows, int col, int fist, int last)
{
    int[,] arr = new int[rows, col];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr[i, j] = new Random().Next(fist, last);
            Console.Write("{0,3}", arr[i, j]);
        }
        Console.WriteLine();
    }
    return arr;
}

// Создание, заполнение случайными числами от 1 до 9 и вывод массива. 
int[,] matrix = GenerateMatrix(3, 4, 0, 10);

// Сортировка элементов в строке массива, по убыванию.
SortingMatrix(matrix);
Console.WriteLine();

// Вывод нового массива (матрицы).
ShowNewMatrix(matrix);