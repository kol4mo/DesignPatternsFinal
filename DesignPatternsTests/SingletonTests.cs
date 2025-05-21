using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternsDemo;

namespace DesignPatternsDemo.Tests
{
    [TestClass]
    [DoNotParallelize]
    public class SingletonTests
    {
        [TestInitialize]
        public void Setup() {
            //reset gamemanager
        }

        [TestMethod]
        public void GetInstance_ReturnsSameInstance()
        {
            // Arrange & Act
            var instance1 = GameManager.Instance;
            var instance2 = GameManager.Instance;

            // Assert
            Assert.IsNotNull(instance1);
            Assert.IsNotNull(instance2);
            Assert.AreSame(instance1, instance2);
        }

        [TestMethod]
        public void Instance_InitialState_IsMenuState()
        {
            // Arrange & Act
            var instance = GameManager.Instance;

            // Assert
            Assert.IsInstanceOfType(instance.CurrentState, typeof(MenuState));
        }
    }
} 