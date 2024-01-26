using System;

public class Program {
    static void DiscoverPath(int P, int R)
    {
        if (P == 0)
            Console.WriteLine("C");

        if (P == 1 && R == 0)
            Console.WriteLine("B");

        if (P == 1 && R == 1)
            Console.WriteLine("A");

    }
    static void Main(string[] args)
    {
         string line = Console.ReadLine();
        string [] data = line.Split(' '); 
        
        int P = int.Parse(data[0]);
        int R = int.Parse(data[1]);

        DiscoverPath(P, R);
    }
}