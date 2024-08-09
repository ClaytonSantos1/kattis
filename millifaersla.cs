using System;

public class Kattis{
    public static void Main(String[] args){
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int x = 0;
        string name;
        
        if(a < b){
            x = a;
            name = "Monnei";
        }else{
            x = b;
            name = "Fjee";
        }
        
        if (c < x){
            name = "Dolladollabilljoll";
        }
        
        Console.WriteLine(name);
    }
}