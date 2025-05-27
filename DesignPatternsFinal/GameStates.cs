using System;

namespace DesignPatternsDemo
{
    /// <summary>
    /// State Interface: Defines possible behaviors that all game states must implement
    /// </summary>
    public interface IGameState
    {
        void EnterState();
        void UpdateState();
        void ExitState();
    }

    /// <summary>
    /// Concrete State: Implements specific behavior for the menu state
    /// </summary>
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

    /// <summary>
    /// Concrete State: Implements specific behavior for the playing state
    /// </summary>
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

    /// <summary>
    /// Concrete State: Implements specific behavior for the paused state
    /// </summary>
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

    /// <summary>
    /// Concrete State: Implements specific behavior for the game over state
    /// </summary>
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