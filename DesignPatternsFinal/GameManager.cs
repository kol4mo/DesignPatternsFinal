using System;

namespace DesignPatternsDemo {
	/// <summary>
	/// GameManager Class: A concrete singleton implementation that manages game states
	/// Also serves as the Context in the State Machine pattern, maintaining the current state
	/// </summary>
	public class GameManager : SingletonBase<GameManager> {
		// Context: Maintains the current state
		public IGameState CurrentState { get; private set; }

		// Private Constructor: Prevents external instantiation
		// This is required by SingletonBase<T> to ensure only one instance exists
		private GameManager() {
			CurrentState = new MenuState();
		}

		// State transition method: Handles state changes and ensures proper cleanup
		public void SetState(IGameState newState) {
			CurrentState?.ExitState();
			CurrentState = newState;
			CurrentState.EnterState();
		}

		// Delegates the update behavior to the current state
		public void Update() {
			CurrentState?.UpdateState();
		}
	}
}
