/* Задача 58: Задайте две матрицы. Напишите программу,
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void GenerateMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 5);
    }
}

int InputNumber(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Ввод размеров, генерация b заполнение 2х матриц, вывод на экран
int rows = InputNumber("Введите количество строк: ");
int col = InputNumber("Введите количество столбцов: ");
int[,] matrix = new int[rows, col];
int[,] secondMatrix = new int[rows, col];
int[,] resultMatrix = new int[rows, col];

GenerateMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();

GenerateMatrix(secondMatrix);
PrintMatrix(secondMatrix);
Console.WriteLine();

// Подсчет произведения матриц
if (matrix.GetLength(0) != secondMatrix.GetLength(1))
{
    Console.WriteLine("Введите одинаковый размер строк и столбцов матрицы");
    return;
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < secondMatrix.GetLength(1); j++)
    {
        resultMatrix[i, j] = 0;
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            resultMatrix[i, j] += matrix[i, k] * secondMatrix[k, j];
        }
    }
}
// Вывод новой матрицы с результатом произведения 
PrintMatrix(resultMatrix);