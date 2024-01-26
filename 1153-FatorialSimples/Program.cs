using System;

public class Program{
    static int Factorial(int number){
        int factorial = 1;
        
        for(int i = 1; i <= number; i++){
            factorial *= i;
        }
        return factorial;
    }
    
    static void Main(string[] args) { 

        int N = int.Parse(Console.ReadLine());
        
        Console.WriteLine( Factorial(N));

    }
    
}
