using System;

namespace SnakeLadderBridgeLabz.Features
{
    public class UC5_ExactWinningPosition
    {
        public static void PlayExact100()
        {
            UC1_SinglePlayerStart.InitializeBoard();
            int position = 0;
            Random random = new Random();

            var ladders = UC1_SinglePlayerStart.GetLadders();
            var snakes = UC1_SinglePlayerStart.GetSnakes();

            while (position != 100)
            {
                int dieRoll = random.Next(1, 7);
                int option = random.Next(0, 3);

                switch (option)
                {
                    case 1:
                        if (position + dieRoll <= 100)
                            position += dieRoll;
                        if (ladders.ContainsKey(position))
                            position = ladders[position];
                        break;

                    case 2:
                        position -= dieRoll;
                        if (position < 0) position = 0;
                        if (snakes.ContainsKey(position))
                            position = snakes[position];
                        break;
                }

                Console.WriteLine($"UC5: Rolled={dieRoll}, Option={option}, Position={position}");
            }

            Console.WriteLine("UC5: Player reached exact 100!");
        }
    }
}

