using System;
					
public class Program
{
    public static void Main(String[] args){
		string s = Console.ReadLine();
       	string[] s1 = s.Split(' ');
		
        int v = Convert.ToInt32(s1[0]);
		int a = Convert.ToInt32(s1[1]);
		int t = Convert.ToInt32(s1[2]);
		
        double d = v * t + 0.5 * a * Math.Pow(t, 2);
		
        Console.WriteLine((float)d);
    }
}