/*Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве 
и возвращает значение этого элемента или же указание, что такого элемента нет*/ 

int getDataFromUser(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
void printInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(data);
    Console.ResetColor();
}
int [,] Generate2DArray(int colLength, int rowLength, int start, int finish)          
{
    int [,] array = new int [colLength,rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
           array[i,j] = new Random().Next(start, finish + 1); 
        }
        
    }
    return array;
}
void print2DArray(int [,] array)
{   
    Console.Write(" \t");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        printInColor(j + "\t");
    }
     Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "\t");
       for (int j = 0; j < array.GetLength(1); j++)
       {
            Console.Write(array[i,j] +"\t");
       } 
       Console.WriteLine();
    }
}
void getElementValue(int [,] array,int colLength, int rowLength, int row,int col)
{
    if (col >= 0 && col <= colLength && row >= 0 && row <= rowLength)
    {
        Console.WriteLine($"Значение элемента с позицией[{col},{row}] : {array [col,row]}");
    }
    else
    {
        Console.WriteLine($"Элемент с позицией[{col},{row}] отсутствует в данном массиве");
    }
}

int colLength = getDataFromUser("Введите количество строк");
int rowLength = getDataFromUser("Введите количество столбцов");
int [,] array = Generate2DArray(colLength,rowLength, 0,10);
print2DArray(array);
Console.WriteLine();
int col = getDataFromUser ("Введите номер столбца");
int row = getDataFromUser ("Введите номер строки");
getElementValue(array, colLength, rowLength, col, row);


