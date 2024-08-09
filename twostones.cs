using System;

public class Kattis{
    public static void Main(string[] args){
        int num = Convert.ToInt32(Console.ReadLine());
        string win = "";
        
        if (num % 2 == 0){
            win = "Bob";    
        }else{
            win = "Alice";
        }
        
        Console.WriteLine(win);
    }
}