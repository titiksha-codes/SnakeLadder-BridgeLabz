using System;
using System.Collections.Generic;

namespace SnakeLadderBridgeLabz.Features
{
	public class UC1_SinglePlayerStart
	{
		private const int BOARD_SIZE = 10;
		private static Dictionary<int, int> ladders;
		private static Dictionary<int, int> snakes;

		public static void InitializeBoard()
		{
			Console.WriteLine("UC1: Snake and Ladder board initialized (10x10).");

			// --- Initialize ladders (start → end) ---
			ladders = new Dictionary<int, int>()
			{
				{ 3, 22 },
				{ 5, 8 },
				{ 11, 26 },
				{ 20, 29 },
				{ 27, 56 },
				{ 72, 92 },
				{ 80, 99 }
			};

			// --- Initialize snakes (start → end) ---
			snakes = new Dictionary<int, int>()
			{
				{ 17, 4 },
				{ 19, 7 },
				{ 21, 9 },
				{ 43, 25 },
				{ 50, 34 },
				{ 62, 18 },
				{ 87, 24 },
				{ 95, 75 },
				{ 99, 78 }
			};

			DisplayBoard();
		}

		private static void DisplayBoard()
		{
			Console.WriteLine("\nSnake and Ladder Board (Positions 1–100):\n");

			for (int row = BOARD_SIZE; row >= 1; row--)
			{
				for (int col = 1; col <= BOARD_SIZE; col++)
				{
					int pos = (row - 1) * BOARD_SIZE + (row % 2 == 0 ? (BOARD_SIZE - col + 1) : col);

					string cellDisplay = pos.ToString("D2");

					if (ladders.ContainsKey(pos))
						cellDisplay = "L↑" + ladders[pos].ToString("D2");
					else if (snakes.ContainsKey(pos))
						cellDisplay = "S↓" + snakes[pos].ToString("D2");

					Console.Write(cellDisplay.PadRight(6));
				}
				Console.WriteLine("\n");
			}

			Console.WriteLine("Ladders:");
			foreach (var ladder in ladders)
				Console.WriteLine($"  From {ladder.Key} → {ladder.Value}");

			Console.WriteLine("\nSnakes:");
			foreach (var snake in snakes)
				Console.WriteLine($"  From {snake.Key} → {snake.Value}");

			Console.WriteLine("\nPlayer starts at position 0.\n");
		}

		public static Dictionary<int, int> GetLadders() => ladders;
		public static Dictionary<int, int> GetSnakes() => snakes;
	}
}


