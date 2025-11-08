uusing System;
public class SnakeAndLadder
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Snake and Ladder Game (2 Players)\n");
        Console.WriteLine("Dice Range: 1 - 6");
        Console.WriteLine("Options:\n 0 - No Play\n 1 - Ladder\n 2 - Snake\n");
        int pos1 = 0, pos2 = 0;
        Random r = new Random();
        bool player1Turn = true;
        while (pos1 < 100 && pos2 < 100)
        {
            string currentPlayer;
            int pos;

            if (player1Turn)
            {
                currentPlayer = "Player 1";
                pos = pos1;
            }
            else
            {
                currentPlayer = "Player 2";
                pos = pos2;
            }
            Console.WriteLine("\n" + currentPlayer + " at " + pos);
            int dice = r.Next(1, 7);
            Console.WriteLine("Dice Number: " + dice);
            int option = r.Next(0, 3);
            if (option == 0)
            {
                Console.WriteLine("Option: No Play — stays in the same position.");
            }
            else if (option == 1)
            {
                int newPos = pos + dice;
                if (newPos > 100)
                {
                    Console.WriteLine("Option: Ladder — Roll exceeds 100! Stay in the same position.");
                }
                else
                {
                    pos = newPos;
                    Console.WriteLine("Option: Ladder — moves ahead by " + dice + " to " + pos);
                }
                if (player1Turn)
                    pos1 = pos;
                else
                    pos2 = pos;
                if (pos == 100)
                    break;
                continue;
            }
            else
            {
                pos -= dice;
                if (pos < 0) pos = 0;
                Console.WriteLine("Option: Snake — moves behind by " + dice + " to " + pos);
            }

            if (player1Turn)
                pos1 = pos;
            else
                pos2 = pos;

            player1Turn = !player1Turn;
        }

        Console.WriteLine("\nGame Over!");
        if (pos1 == 100)
            Console.WriteLine("Player 1 Wins!");
        else
            Console.WriteLine("Player 2 Wins!");
    }
}