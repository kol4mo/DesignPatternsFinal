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

        
    }
} 