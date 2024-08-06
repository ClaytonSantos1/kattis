using System;
public class Kattis{
    public static void Main(String[] args){

        int n = Convert.ToInt32(Console.ReadLine());

        if (n % 10 == 0){
            Console.WriteLine("Jebb");
        }else{
            Console.WriteLine("Neibb");
        }
    }
}