using System;
using System.Linq;

public class Kattis{
    public static void Main(String[] args){
        string s = Console.ReadLine();
        string sReverse = new string(s.Reverse().ToArray());
        
        Console.WriteLine(sReverse);
    }
}