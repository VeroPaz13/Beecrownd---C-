using System;

public class Program
{
    static void Main(string[] args)
    {
        int numberCells = int.Parse(Console.ReadLine());
        int[] minefield = new int[numberCells];
        int[] resultMinefield = new int[numberCells];

        for (int i = 0; i < numberCells; i++)
        {
            minefield[i] = int.Parse(Console.ReadLine());
        }

        for (int j = 0; j < numberCells; j++)
        {
            // Verifica se há uma mina na célula atual
            if (minefield[j] == 1)
            {
                resultMinefield[j] = 1; 
            }

            // Verifica a célula à esquerda
            if (j > 0 && minefield[j - 1] == 1)
            {
                resultMinefield[j]++;
            }

            // Verifica a célula à direita
            if (j < numberCells - 1 && minefield[j + 1] == 1)
            {
                resultMinefield[j]++;
            }
        }

        for (int index = 0; index < numberCells; index++)
        {
            Console.WriteLine(resultMinefield[index]);
        }
    }
}