using System;
using System.Globalization;
public class SnakeAndLadder
{
    public static void Main(String[] args)
    {
        int pos = 0;
        Console.WriteLine($"Player at {pos} ");
        Random r = new Random();
        int dice = r.Next(1, 7);
        Console.WriteLine($"Dice Number: {dice}");
    }
}
