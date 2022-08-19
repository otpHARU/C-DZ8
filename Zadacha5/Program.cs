// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int rows = InputNumbers("Обозначьте количество строк и столбцов одним числом: ");
int columns = rows;

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,] spiralMatrix)
{
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= spiralMatrix.GetLength(0) * spiralMatrix.GetLength(1))
    {
        spiralMatrix[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < spiralMatrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= spiralMatrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > spiralMatrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }
}

void WriteArray(int[,] spiralMatrix)
{
    for (int i = 0; i < spiralMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < spiralMatrix.GetLength(1); j++)
        {
            Console.Write(spiralMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] spiralMatrix = new int[rows, columns];

CreateArray(spiralMatrix);
WriteArray(spiralMatrix);