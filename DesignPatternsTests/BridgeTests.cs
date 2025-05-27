using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using DesignPatternsDemo;

namespace DesignPatternsDemo.Tests
{
    [TestClass]
    [DoNotParallelize]
    public class BridgeTests
    {
        private class TestWriter : StringWriter
        {
            public override void WriteLine(string? value)
            {
                base.WriteLine(value);
            }
        }

        private TestWriter? testWriter;

        [TestInitialize]
        public void Setup()
        {
            GameManager.Reset(); // Reset game manager to prevent state interference
            testWriter = new TestWriter();
            Console.SetOut(testWriter);
        }

        private string GetOutput()
        {
            var output = testWriter?.ToString().Trim() ?? string.Empty;
            testWriter?.GetStringBuilder().Clear();
            return output;
        }

        [TestMethod]
        public void Warrior_WithAggressiveBehavior_PerformsCorrectActions()
        {
            // Arrange
            var warrior = new Barbarian(new AggressiveBehavior());

            // Act & Assert - Display
            warrior.Display();
            Assert.AreEqual("I am a Barbarian!", GetOutput());

            // Act & Assert - Move
            warrior.PerformMove();
            Assert.AreEqual("Running fast towards enemy", GetOutput());

            // Act & Assert - Attack
            warrior.PerformAttack();
            Assert.AreEqual("Performing powerful attack", GetOutput());
        }

        [TestMethod]
        public void Mage_WithDefensiveBehavior_PerformsCorrectActions()
        {
            // Arrange
            var mage = new Mage(new DefensiveBehavior());

            // Act & Assert - Display
            mage.Display();
            Assert.AreEqual("I am a Mage.", GetOutput());

            // Act & Assert - Move
            mage.PerformMove();
            Assert.AreEqual("Moving cautiously", GetOutput());

            // Act & Assert - Defend
            mage.PerformDefend();
            Assert.AreEqual("Using strong defensive stance", GetOutput());
        }

        [TestMethod]
        public void Characters_CanSwitchBehaviors()
        {
            // Arrange
            var warrior = new Barbarian(new DefensiveBehavior());
            var mage = new Mage(new AggressiveBehavior());

            // Act & Assert - Warrior with defensive behavior
            warrior.PerformMove();
            Assert.AreEqual("Moving cautiously", GetOutput());

            // Act & Assert - Mage with aggressive behavior
            mage.PerformAttack();
            Assert.AreEqual("Performing powerful attack", GetOutput());
        }
    }
} 