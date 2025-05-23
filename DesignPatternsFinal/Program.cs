using System;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace DesignPatternsDemo
{
    class Program
    {
        static void Main(string[] args)
        {

			Console.WriteLine("Design Patterns Demo - Singleton, State Machine, and Bridge");

			GameManager gameManager = GameManager.Instance;
			bool isRunning = true;
			while (isRunning) {
				Console.WriteLine();
				Console.WriteLine("\nCurrent Game State:");
				gameManager.Update();


				var key = Console.ReadKey(true).Key;
				switch (key) {
					case ConsoleKey.P:
						if (gameManager.CurrentState is MenuState)
							gameManager.SetState(new PlayingState());
						else if (gameManager.CurrentState is PlayingState)
							gameManager.SetState(new PausedState());
						else if (gameManager.CurrentState is PausedState)
							gameManager.SetState(new PlayingState());
						break;

					case ConsoleKey.R:
						if (gameManager.CurrentState is GameOverState)
							gameManager.SetState(new PlayingState());
						break;

					case ConsoleKey.Q:
						if (gameManager.CurrentState is PlayingState)
							gameManager.SetState(new GameOverState());
						else
							isRunning = false;
						break;
				}

				Thread.Sleep(100); // Small delay to prevent CPU overuse
			}
			Console.WriteLine("\nThank you for testing the design patterns!");
        }
    }
}
