using System;

public class Program{

    static void Main(string[] args)
    {
        int operationLine = int.Parse(Console.ReadLine());
        string operation = Console.ReadLine();
        double sum = 0.0;
        double average = 0.0;
        int lines = 12;
        int columns = 12;
        double[,] matrix = new double[lines, columns];

        for (int i = 0; i < lines; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = double.Parse(Console.ReadLine());
            }
        }
        
        for (int i = 0; i < lines; i++)
        {      
            sum += matrix[operationLine, i];
        }

        if (operation.Contains("S"))
        {
            Console.WriteLine(sum.ToString("F1"));
        }
        else
        {
            average = sum / lines;
            Console.WriteLine(average.ToString("F1"));
        }

    }
}
