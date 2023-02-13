/* Задача 52: Задайте двумерный массив из целых чисел. найдите среднее арифметическое элементов в каждом столбце*/ int getDataFromUser(string message)
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
int [,] get2DArray(int colLength, int rowLength, int start, int end)
{
    int [,] array = new int[colLength,rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i,j] = new Random().Next(start,end+1);
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
void getArithmeticMean(int [,] array,int rowLength,int colLength )
{
    double  ArithmeticMean = sum[i]/rowLength;
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            sum [i] += array[j,i];
        }
        
    }
    return ArithmeticMean;
}
int rowLength = getDataFromUser ("Введите количество строк");
int colLength = getDataFromUser ("Введите количество столбцов");
int [,] array = get2DArray (rowLength,colLength,0,100);
print2DArray (array);
Console.WriteLine();
double ArithmeticMean = getArithmeticMean(array,rowLength,colLength);
Console.WriteLine($"Среднее арифметическое элементов в столбцах {ArithmeticMean}");



