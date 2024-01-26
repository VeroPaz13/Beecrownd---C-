using System;

public class Program {
    static void Multiplication(int N)
    {
        for (int i = 1; i <= 10; i++)
        {
            int result = i * N;
            Console.WriteLine($"{i} x {N} = {result}");
        }

    }
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        
        Multiplication(N);
    }
}