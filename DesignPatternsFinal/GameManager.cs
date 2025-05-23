using System;

namespace DesignPatternsDemo {
	public class GameManager : SingletonBase<GameManager> {
		public IGameState CurrentState { get; private set; }

		// Private constructor required by SingletonBase
		private GameManager() {
			CurrentState = new MenuState();
		}

		public void SetState(IGameState newState) {
			CurrentState?.ExitState();
			CurrentState = newState;
			CurrentState.EnterState();
		}

		public void Update() {
			CurrentState?.UpdateState();
		}
	}
}
