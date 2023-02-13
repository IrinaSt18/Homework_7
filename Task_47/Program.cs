/*Задача 47: */
int getUserData(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
void printInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(data);
    Console.ResetColor();
}
double [,] get2DDoubleArray(int colLength, int rowLength, int start, int finish)
{
    double [,] array = new double[colLength,rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i,j] = new Random().Next(start,finish+1)+ Math.Round(new Random().NextDouble(),2);
        }  
    }
    return array;
}
void print2DArray(double [,] array)
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
int n = getUserData ("Введите количество строк");
int m = getUserData ("Введите количество столбцов");
double[,] array = get2DDoubleArray(n,m,0,1000);
print2DArray(array);