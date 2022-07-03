// // Задача 1: Задайте двумерный массив. Напишите программу, 
// // которая упорядочит по убыванию элементы каждой строки двумерного массива.


int[,] GenerateArray(int row, int column)
{
    var array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 9);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void ReorderRowBigToSmall(int[,] array)
{
    int j = 0;
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (j = 0; j < array.GetLength(1); j++)
        {
            int max = j;
            for (count = j; count < array.GetLength(1); count++)
            {
                if (array[i, max] < array[i, count])
                {
                    max = count;
                }
            }
            int temp = array[i, max];
            array[i, max] = array[i, j];
            array[i, j] = temp;
        }
    }
}

int row = 5;
int column = 5;

int[,] TestArray = GenerateArray(row, column);
Console.WriteLine("Задаем двумерный массив: ");
PrintArray(TestArray);
Console.WriteLine("Упорядочиваем по убыванию элементы каждой строки двумерного массива: ");
ReorderRowBigToSmall(TestArray);
PrintArray(TestArray);
