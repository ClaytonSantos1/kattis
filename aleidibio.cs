using System;

public class Kattis{
    public static void Main(String[] args){
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine(c - (a + b));
    }
}