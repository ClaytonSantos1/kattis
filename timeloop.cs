using System;

public class Kattis{
    public static void Main(String[] args){
        int num = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 0;i < num;i++){
            Console.WriteLine($"{i+1} Abracadabra");
        }
    }
}