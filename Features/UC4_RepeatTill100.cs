using System;

namespace SnakeLadderBridgeLabz.Features
{
    public class UC4_RepeatTill100
    {
        public static void PlayTill100()
        {
            UC1_SinglePlayerStart.InitializeBoard();
            int position = 0;
            Random random = new Random();

            var ladders = UC1_SinglePlayerStart.GetLadders();
            var snakes = UC1_SinglePlayerStart.GetSnakes();

            while (position < 100)
            {
                int dieRoll = random.Next(1, 7);
                int option = random.Next(0, 3); // 0-No Play, 1-Ladder, 2-Snake

                switch (option)
                {
                    case 1:
                        position += dieRoll;
                        if (position > 100) position = 100;
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

                Console.WriteLine($"UC4: Die={dieRoll}, Option={option}, Position={position}");
            }

            Console.WriteLine("UC4: Player reached position 100!");
        }
    }
}
