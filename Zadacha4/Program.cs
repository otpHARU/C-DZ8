// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int rows = InputNumbers("Введите количество строк: ");
int columns = InputNumbers("Введите количество столбцов: ");
int depth = InputNumbers("Введите количество страниц: ");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,,] matrix3D)
{
  int[] temp = new int[matrix3D.GetLength(0) * matrix3D.GetLength(1) * matrix3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < matrix3D.GetLength(0); x++)
  {
    for (int y = 0; y < matrix3D.GetLength(1); y++)
    {
      for (int z = 0; z < matrix3D.GetLength(2); z++)
      {
        matrix3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

void WriteArray(int[,,] matrix3D)
{
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        Console.WriteLine("Страница №: " + (i + 1));

        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                Console.Write($"{matrix3D[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("=======================");
    }
}

int[,,] matrix3D = new int[depth, rows, columns];
CreateArray(matrix3D);
WriteArray(matrix3D);












