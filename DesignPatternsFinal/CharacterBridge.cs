using System;

namespace DesignPatternsDemo {
	// Implementation Interface: Defines low-level behavior
	public interface ICharacterBehavior {
		void Move();
		void Attack();
		void Defend();
	}

	// Concrete Implementations: Implements low-level behavior
	public class AggressiveBehavior : ICharacterBehavior {
		public void Move() {
			Console.WriteLine("Running fast towards enemy");
		}

		public void Attack() {
			Console.WriteLine("Performing powerful attack");
		}

		public void Defend() {
			Console.WriteLine("Using offensive defense");
		}
	}

	public class DefensiveBehavior : ICharacterBehavior {
		public void Move() {
			Console.WriteLine("Moving cautiously");
		}

		public void Attack() {
			Console.WriteLine("Performing calculated attack");
		}

		public void Defend() {
			Console.WriteLine("Using strong defensive stance");
		}
	}

	// Abstraction: Defines high-level behavior
	public abstract class Character {
		protected ICharacterBehavior behavior;

		protected Character(ICharacterBehavior behavior) {
			this.behavior = behavior;
		}

		public abstract void Display(); // Abstract method extended by refined abstractions

		public void PerformMove() {
			behavior.Move();
		}

		public void PerformAttack() {
			behavior.Attack();
		}

		public void PerformDefend() {
			behavior.Defend();
		}
	}

	// Refined Abstractions: Extends abstraction behavior
	public class Barbarian : Character {
		public Barbarian(ICharacterBehavior behavior) : base(behavior) { }

		public override void Display() {
			Console.WriteLine("I am a Barbarian!");
		}
	}

	public class Mage : Character {
		public Mage(ICharacterBehavior behavior) : base(behavior) { }

		public override void Display() {
			Console.WriteLine("I am a Mage.");
		}
	}
}
