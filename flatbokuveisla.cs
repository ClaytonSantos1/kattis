using System;

public class Kattis{
    public static void Main(String[] args){
        int n = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());
        int r = n % m;
        
        Console.WriteLine(r);
    }
}