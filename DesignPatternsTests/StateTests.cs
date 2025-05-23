using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternsDemo;

namespace DesignPatternsDemo.Tests
{
    [TestClass]
    [DoNotParallelize]
    public class StateTests
    {
        private GameManager? gameManager;

        [TestInitialize]
        public void Setup()
        {
            GameManager.Reset();
            gameManager = GameManager.Instance;
        }

        [TestMethod]
        public void SetState_ChangesToPlayingState_StateChangedSuccessfully()
        {
            // Arrange
            var playingState = new PlayingState();

            // Act
            gameManager!.SetState(playingState);

            // Assert
            Assert.IsInstanceOfType(gameManager.CurrentState, typeof(PlayingState));
        }

        [TestMethod]
        public void SetState_ChangesToPausedState_StateChangedSuccessfully()
        {
            // Arrange
            var pausedState = new PausedState();

            // Act
            gameManager!.SetState(pausedState);

            // Assert
            Assert.IsInstanceOfType(gameManager.CurrentState, typeof(PausedState));
        }

        [TestMethod]
        public void SetState_ChangesToGameOverState_StateChangedSuccessfully()
        {
            // Arrange
            var gameOverState = new GameOverState();

            // Act
            gameManager!.SetState(gameOverState);

            // Assert
            Assert.IsInstanceOfType(gameManager.CurrentState, typeof(GameOverState));
        }
    }
} 