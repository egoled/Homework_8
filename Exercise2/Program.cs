// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

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

int FindSumRowElement (int[,] array, int row)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1);j++)
    {
        sum = sum + array[row, j];
    }
    return sum;
}

int [] FindMinimumSum (int [,] array)
{
    int[] NewRowSum = new int[2];
    NewRowSum[1] = FindSumRowElement(array,NewRowSum[0]);
    for (int i = 0; i < array.GetLength(0);i++)
    {
        if (NewRowSum[1] > FindSumRowElement(array,i))
        {
            NewRowSum[0] = i;
            NewRowSum[1] = FindSumRowElement(array, NewRowSum[0]);
        }
    }
    return NewRowSum;
}

int row = 8;
int column = 6;

int[,] TestArray = GenerateArray(row, column);
Console.WriteLine("Задаем двумерный массив: ");
PrintArray(TestArray);
Console.WriteLine();
System.Console.WriteLine($"Строка с наименьшей суммой элементов: {FindMinimumSum(TestArray)[0]}");
