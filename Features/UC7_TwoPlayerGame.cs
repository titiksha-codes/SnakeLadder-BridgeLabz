using System;

namespace SnakeLadderBridgeLabz.Features
{
    public class UC7_TwoPlayerGame
    {
        public static void PlayTwoPlayers()
        {
            UC1_SinglePlayerStart.InitializeBoard();

            int p1 = 0, p2 = 0;
            int rolls1 = 0, rolls2 = 0;
            bool isPlayer1Turn = true;
            Random random = new Random();

            var ladders = UC1_SinglePlayerStart.GetLadders();
            var snakes = UC1_SinglePlayerStart.GetSnakes();

            while (p1 < 100 && p2 < 100)
            {
                int dieRoll = random.Next(1, 7);
                int option = random.Next(0, 3);
                string player = isPlayer1Turn ? "Player 1" : "Player 2";

                if (isPlayer1Turn) rolls1++; else rolls2++;
                int pos = isPlayer1Turn ? p1 : p2;

                switch (option)
                {
                    case 1: // Ladder
                        if (pos + dieRoll <= 100)
                            pos += dieRoll;
                        if (ladders.ContainsKey(pos))
                            pos = ladders[pos];
                        Console.WriteLine($"{player}: Ladder! New Position {pos}. Rolls again!");
                        if (isPlayer1Turn) p1 = pos; else p2 = pos;
                        continue; // extra turn
                    case 2: // Snake
                        pos -= dieRoll;
                        if (pos < 0) pos = 0;
                        if (snakes.ContainsKey(pos))
                            pos = snakes[pos];
                        Console.WriteLine($"{player}: Snake! New Position {pos}");
                        break;
                    default:
                        Console.WriteLine($"{player}: No Play, stays at {pos}");
                        break;
                }

                if (isPlayer1Turn) p1 = pos; else p2 = pos;
                isPlayer1Turn = !isPlayer1Turn;
            }

            string winner = p1 == 100 ? "Player 1" : "Player 2";
            Console.WriteLine($"\nUC7: {winner} wins!");
            Console.WriteLine($"Player 1 rolls: {rolls1}, Player 2 rolls: {rolls2}");
        }
    }
}
