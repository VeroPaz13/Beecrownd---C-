using System;

public class Program{

    static void Main(string[] args) { 

        int numberCases = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < numberCases; i++)
        {
            int numberToTest = int.Parse(Console.ReadLine());
            bool isPrime = true;
            
            for(int j = 2; j <= Math.Sqrt(numberToTest); j++)
            {
                if(numberToTest % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if(isPrime)
            {
                Console.WriteLine($"{numberToTest} eh primo");
            }else
                Console.WriteLine($"{numberToTest} nao eh primo");
            {
                
            }
        }

    }

}