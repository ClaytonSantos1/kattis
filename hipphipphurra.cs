using System;

public class Kattis{
    public static void Main(String[] args){
        string name = Console.ReadLine();
        int age = Convert.ToInt16(Console.ReadLine());
        
        for(int i = 0; i < age; i++){
            Console.WriteLine($"Hipp hipp hurra, {name}!");
        }
    }
}