using System;
public class SnakeAndLadder
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Player Starts From 0\n");
        Console.WriteLine("Dice Range: 1 - 6");
        Console.WriteLine("Options:\n 0 - No Play\n 1 - Ladder\n 2 - Snake\n");
        int pos = 0;
        Random r = new Random();
        while (pos < 100)
        {
            Console.WriteLine($"\nPlayer at {pos}");
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
                if (pos > 100) pos = 100;
                Console.WriteLine($"Option: Ladder — Player moves ahead by {dice} to {pos}");
            }
            else
            {
                pos -= dice;
                if (pos < 0) pos = 0;
                Console.WriteLine($"Option: Snake — Player moves behind by {dice} to {pos}");
            }
        }

        Console.WriteLine("\nPlayer reached 100!");
    }
}