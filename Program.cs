using System;
using SnakeLadderBridgeLabz.Features;

namespace SnakeLadderBridgeLabz.Features
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Snake and Ladder Simulator ===");
            Console.WriteLine("Select UC to run (1–7): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    UC1_SinglePlayerStart.InitializeBoard();
                    break;
                case 2:
                    UC2_RollDie.RollAndMove();
                    break;
                case 3:
                    UC3_OptionCheck.PlayOption();
                    break;
                case 4:
                    UC4_RepeatTill100.PlayTill100();
                    break;
                case 5:
                    UC5_ExactWinningPosition.PlayExact100();
                    break;
                case 6:
                    UC6_CountDiceRolls.CountRolls();
                    break;
                case 7:
                    UC7_TwoPlayerGame.PlayTwoPlayers();
                    break;
                default:
                    Console.WriteLine("Invalid UC number.");
                    break;
            }
            Console.WriteLine("\nSimulation complete. Press any key to exit.");
            Console.ReadKey();
        }
    }
}

