using System;
class Kattis
{
    static void Main()
    {
        string? input = Console.ReadLine();
        string shortVariation = TransformToShortVariation(input);
        Console.WriteLine(shortVariation);
    }

    static string TransformToShortVariation(string input)
    {
        string result = string.Empty;
        foreach (char c in input)
        {
            if (char.IsUpper(c))
            {
                result += c;
            }
        }
        return result;
    }
}