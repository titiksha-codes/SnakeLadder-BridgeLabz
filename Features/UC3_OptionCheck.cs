using System;

namespace SnakeLadderBridgeLabz.Features
{
    public class UC3_OptionCheck
    {
        public static void PlayOption()
        {
            UC1_SinglePlayerStart.InitializeBoard();
            int position = 0;
            Random random = new Random();

            var ladders = UC1_SinglePlayerStart.GetLadders();
            var snakes = UC1_SinglePlayerStart.GetSnakes();

            int dieRoll = random.Next(1, 7);
            int option = random.Next(0, 3); // 0-No Play, 1-Ladder, 2-Snake

            Console.WriteLine($"\nUC3: Rolled {dieRoll}, Option {option}");

            switch (option)
            {
                case 0:
                    Console.WriteLine($"No Play → stays at {position}");
                    break;

                case 1:
                    position += dieRoll;
                    if (position > 100) position = 100;

                    if (ladders.ContainsKey(position))
                    {
                        Console.WriteLine($"Ladder from {position} to {ladders[position]}!");
                        position = ladders[position];
                    }
                    Console.WriteLine($"Now at {position}");
                    break;

                case 2:
                    position -= dieRoll;
                    if (position < 0) position = 0;

                    if (snakes.ContainsKey(position))
                    {
                        Console.WriteLine($"Snake from {position} to {snakes[position]}!");
                        position = snakes[position];
                    }
                    Console.WriteLine($"Now at {position}");
                    break;
            }
        }
    }
}
