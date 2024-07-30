using System;

public class Kattis{
    public static void Main(String[] args){
        char[] c = Console.ReadLine().ToCharArray();

        foreach (char c2 in c){
            Console.Write(c2);
        }
    }
}