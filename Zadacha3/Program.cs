// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, заданы 2 массива:

// 1 4 7 2           1 5 8 5                                                         1 20 56 10   
// 5 9 2 3     и     4 9 4 2      Их произведение будет равно следующему массиву:    20 81 8 6
// 8 4 2 4           7 2 2 6                                                         56 8 4 24   
// 5 2 6 7           2 3 4 7                                                         10 6 24 49   

int firstRows = InputNumbers("Введите количество строк первой матрицы: ");
int firstColumns = InputNumbers("Введите количество столбцов первой матрицы: ");
int secondRows = InputNumbers("Введите количество строк второй матрицы: ");
int secondColumns = InputNumbers("Введите количество столбцов второй матрицы: ");
if (firstColumns != secondColumns || firstRows != secondRows)
{
    Console.WriteLine();
    Console.WriteLine($"Умножение невозможно! Количество строк и столбцов должно совпадать.");
    return;
}
int range = InputNumbers("Введите диапазон: от 1 до ");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(range);
        }
    }
}

void WriteArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] sumMatrix)
{
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            sumMatrix[i,j] = firstMatrix[i,j] * secondMatrix[i,j];
        }
    }
}

int[,] firstMatrix = new int[firstRows, firstColumns];
CreateArray(firstMatrix);
Console.WriteLine($"\nПервая матрица:");
WriteArray(firstMatrix);

int[,] secondMatrix = new int[secondRows, secondColumns];
CreateArray(secondMatrix);
Console.WriteLine($"\nВторая матрица:");
WriteArray(secondMatrix);

int[,] sumMatrix = new int[firstRows, secondColumns];
MultiplyMatrix(firstMatrix, secondMatrix, sumMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
WriteArray(sumMatrix);











