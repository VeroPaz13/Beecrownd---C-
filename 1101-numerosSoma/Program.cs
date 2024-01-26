using System;

public class Program {
    static void Main(string[] args) { 
    
            
        while(true)
        {
        string line = Console.ReadLine();
        string[] data = line.Split(' ');
            
        int M = int.Parse(data[0]);
        int N = int.Parse(data[1]);

        if(M <= 0 || N <= 0)
            break;

            if(M < N)
            {
                int sum = 0;
                for(int i = M; i <= N; i++)
                {
                    sum += i;
                    Console.Write(i + " ");
                }
                Console.WriteLine($"Sum={sum}");
                
            }

            if(M > N)
            {
                int sum = 0;
                for(int i = N; i <= M; i++)
                {
                    sum += i;
                    Console.Write(i + " ");
                }
                Console.WriteLine($"Sum={sum}");
                
            }

        }

    }
}
