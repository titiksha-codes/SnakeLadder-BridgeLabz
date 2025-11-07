using System;

namespace SnakeLadderBridgeLabz.Features
{
    public class UC2_RollDie
    {
        public static void RollAndMove()
        {
            UC1_SinglePlayerStart.InitializeBoard();

            int position = 0;
            Random random = new Random();
            int dieRoll = random.Next(1, 7);

            Console.WriteLine($"\nUC2: Player rolled {dieRoll}");

            position += dieRoll;
            Console.WriteLine($"UC2: Player moved to {position}");
        }
    }
}
