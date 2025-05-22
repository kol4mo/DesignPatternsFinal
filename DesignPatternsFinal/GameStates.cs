using System;

namespace DesignPatternsDemo
{
    public interface IGameState
    {
        void EnterState();
        void UpdateState();
        void ExitState();
    }

    public class MenuState : IGameState
    {
        public void EnterState()
        {
            Console.WriteLine("Entering Menu State");
        }

        public void UpdateState()
        {
            Console.WriteLine("In Menu State - Press 'P' to start playing, 'Q' to quit");
        }

        public void ExitState()
        {
            Console.WriteLine("Exiting Menu State");
        }
    }

    public class PlayingState : IGameState
    {
        public void EnterState()
        {
            Console.WriteLine("Starting Game");
        }

        public void UpdateState()
        {
            Console.WriteLine("Game is Running - Press 'P' to pause, 'Q' to quit");
        }

        public void ExitState()
        {
            Console.WriteLine("Stopping Game");
        }
    }

    public class PausedState : IGameState
    {
        public void EnterState()
        {
            Console.WriteLine("Game Paused");
        }

        public void UpdateState()
        {
            Console.WriteLine("Game is Paused - Press 'P' to resume, 'Q' to quit");
        }

        public void ExitState()
        {
            Console.WriteLine("Resuming Game");
        }
    }

    public class GameOverState : IGameState
    {
        public void EnterState()
        {
            Console.WriteLine("Game Over!");
        }

        public void UpdateState()
        {
            Console.WriteLine("Game Over - Press 'R' to restart, 'Q' to quit");
        }

        public void ExitState()
        {
            Console.WriteLine("Resetting Game");
        }
    }
} 