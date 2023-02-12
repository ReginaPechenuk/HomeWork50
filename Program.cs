// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int getDataFronUser(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int[,] getArray(int colLength, int rowLength, int start, int Finish)
{
    int[,] array = new int[colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i, j] = new Random().Next(start, Finish + 1);
        }
    }
    return array;
}
void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int FindNumber(int[,] array, int col, int row)
{
    int number = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i==col-1 && j ==row-1)
            {
                number = array[i,j];
            }
           
        }
    }

    return number;
}

int n = getDataFronUser("Введите количествуо строк = ");
int m = getDataFronUser("Введите количествуо столбцов = ");
int[,] array = getArray(n, m, 0, 10);
Console.WriteLine();
printArray(array);

int n1 = getDataFronUser("Введите значение строки искомого элемента = ");
int m1 = getDataFronUser("Введите значение столбца искомого элемента = ");
int NumberU = FindNumber(array,n1,m1);
Console.WriteLine ($"Значение элемента [{n1},{m1}] = {NumberU}");
if (n1>n && m1>m)
{
    Console.WriteLine("такого числа нет");
}
