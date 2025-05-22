using System;

namespace DesignPatternsDemo
{
    public class GameManager
    {
        private static GameManager? instance;
        private static readonly object lockObject = new object();

		public IGameState CurrentState { get; private set; }

		// Private constructor to prevent direct instantiation
		private GameManager()
        {
			CurrentState = new MenuState();
		}
        
        public static GameManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        instance ??= new GameManager();
                    }
                }
                return instance;
            }
        }


		public void SetState(IGameState newState) {
			if (CurrentState != null) {
				CurrentState.ExitState();
			}
			CurrentState = newState;
			CurrentState.EnterState();
		}

		public void Update() {
			CurrentState?.UpdateState();
		}

		// Added for testing purposes
		public static void Reset()
        {
            instance = null;
        }
    }
} 