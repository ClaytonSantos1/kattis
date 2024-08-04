using System;

public class Kattis{
    public static void Main(String[] args){
        string s = Console.ReadLine();
        int r = Convert.ToInt16(Console.ReadLine());
        
        for (int i = 0;i < r;i++){
            Console.Write(s);
        }
    }
}