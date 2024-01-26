using System;

public class Program
{
    static void FindQuadrant(float x, float y)
    {
        if(x == 0.0 && y == 0.0){
            Console.WriteLine("Origem");
        }else if(x == 0 && y != 0){
            Console.WriteLine("Eixo Y");
       }else if(x != 0 && y == 0){
            Console.WriteLine("Eixo X");
            
        }else if(x >= 0.1 && y >= 0.1)
        {
            Console.WriteLine("Q1");
            
        }else if(x < 0.0 && y >= 0.1)
        {
            Console.WriteLine("Q2");
            
        }else if(x < 0.0 && y < 0.0)
        {
            Console.WriteLine("Q3");
            
        }else
        {
            Console.WriteLine("Q4");
            
        }
    }
    static void Main(string[] args) { 

        string line = Console.ReadLine();
        string[] data = line.Split(' ');
        float x = float.Parse(data[0]);
        float y = float.Parse(data[1]);

        FindQuadrant(x,y);
    }


}