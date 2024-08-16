using System;

public class Kattis{
    public static void Main(String[] args){
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        int quadrant = 0;
        
        if (x > 0 && y > 0){
            quadrant = 1;
        }
        else if (x < 0 && y > 0){
            quadrant = 2;
        }
        else if (x < 0 && y < 0){
            quadrant = 3;
        }
        else if (x > 0 && y < 0){
            quadrant = 4;
        }
        else{
            quadrant = 0;
        }

        Console.WriteLine("" + quadrant);
    }
}