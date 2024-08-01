using System;

public class Kattis{
    public static void Main(String[] args){
  
        int ano = 2022;
        int n = Convert.ToInt32(Console.ReadLine());
        int k = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine(ano + (n / k));
    }
}