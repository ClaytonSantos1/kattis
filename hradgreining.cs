using System;

public class Kattis{
    public static void Main(String[] args){
        string dna = Console.ReadLine();
        
        if (dna.Contains("COV")){
            Console.WriteLine("Veikur!");
        }else{
            Console.WriteLine("Ekki veikur!");
        }
    }
}