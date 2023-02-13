/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка
*/

void NumRowMinSumElements(int[,] matrix)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
        minRow += matrix[0, i];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            sumRow += matrix[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"  {minSumRow + 1} строка (с наименьшей суммой элементов)");
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

// Создание, заполнение случайными числами от 0 до 9 и вывод массива. 
int[,] matrix = GenerateMatrix(4, 4, 0, 10);
Console.WriteLine();

// Подсчёт и вывод номера строки с наименьшей суммой элементов.
NumRowMinSumElements(matrix);