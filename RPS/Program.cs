using System;

namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            GameItem p1 = (GameItem)Enum.Parse(typeof(GameItem), args[0]);
            GameItem p2 = (GameItem)Enum.Parse(typeof(GameItem), args[1]);

            GameStatus result = RockPaperScissors(p1, p2);

            switch (result)
            {
                case GameStatus.Draw:
                    Console.WriteLine("It's a draw!");
                    break;
                case GameStatus.Player1Wins:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case GameStatus.Player2Wins:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }

        private static GameStatus RockPaperScissors(GameItem p1, GameItem p2)
        {
            if (p1 == p2)
            {
                return GameStatus.Draw;
            }
            else if (((p1 == GameItem.Rock) && (p2 == GameItem.Scissors)) ||
                     ((p1 == GameItem.Scissors) && (p2 == GameItem.Paper)) ||
                     ((p1 == GameItem.Paper) && (p2 == GameItem.Rock)))
            {
                return GameStatus.Player1Wins;
            }
            else
            {
                return GameStatus.Player2Wins;
            }
        }
    }
}
