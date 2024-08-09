using System;

public class Kattis{
    public static void Main(string[] args){
        int num = Convert.ToInt32(Console.ReadLine());
        string name = "";

        for(int i = 0; i < num; i++){
            name = Console.ReadLine();
        }

        if(num > 1){
            Console.WriteLine("blandad best");
        }else{
            Console.WriteLine(name);
        }
    }
}