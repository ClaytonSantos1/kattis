using System;

public class Kattis{
    public static void Main(String[] args){
        int num = Convert.ToInt32(Console.ReadLine());
        string[] names = new string[num];
        
        for(int i = 0; i < num; i++){
            names[i] = Console.ReadLine();
        }
        
        for(int i = 0; i < num; i++){
            Console.WriteLine($"Takk {names[i]}");
        }
    }
}