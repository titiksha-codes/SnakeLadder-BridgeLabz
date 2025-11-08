using System;

public class SnakeAndLadder
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Player Starts From 0\n");
        Console.WriteLine("1 - 6 : Dice Roll");
        Console.WriteLine(" 0 - No Play \n 1 - Ladder \n 2 - Snake\n\n");

        int pos = 0;
        Console.WriteLine($"Player at {pos} ");
        Random r = new Random();
        int dice = r.Next(1, 7);
        Console.WriteLine($"Dice Number: {dice}");

        int option = r.Next(0, 3);
        if (option == 0)
        {
            Console.WriteLine("Option: No Play — Player stays in the same position.");
        }
        else if (option == 1)
        {
            pos += dice;
            Console.WriteLine($"Option: Ladder — Player moves ahead by {dice} to {pos}");
        }
        else
        {
            pos -= dice;
            if (pos < 0) pos = 0;
            Console.WriteLine($"Option: Snake — Player moves behind by {dice} to {pos}");
        }

        Console.WriteLine($"Current Position: {pos}");
    }
}