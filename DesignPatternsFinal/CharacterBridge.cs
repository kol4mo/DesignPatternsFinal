using System;

namespace DesignPatternsDemo {
	/// <summary>
	/// Implementation Interface: Defines low-level behavior that can be implemented in different ways
	/// This is the "implementation" side of the bridge pattern
	/// </summary>
	public interface ICharacterBehavior {
		void Move();
		void Attack();
		void Defend();
	}

	/// <summary>
	/// Concrete Implementation: Implements aggressive low-level behavior
	/// </summary>
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

	/// <summary>
	/// Concrete Implementation: Implements defensive low-level behavior
	/// </summary>
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

	/// <summary>
	/// Abstraction: Defines high-level behavior and holds a reference to the implementation
	/// This is the "abstraction" side of the bridge pattern
	/// </summary>
	public abstract class Character {
		// Bridge: Reference to the implementation
		protected ICharacterBehavior behavior;

		protected Character(ICharacterBehavior behavior) {
			this.behavior = behavior;
		}

		// Abstract method that must be implemented by refined abstractions
		public abstract void Display();

		// High-level operations that delegate to the implementation
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

	/// <summary>
	/// Refined Abstraction: Extends the abstraction with specific character type behavior
	/// </summary>
	public class Barbarian : Character {
		public Barbarian(ICharacterBehavior behavior) : base(behavior) { }

		public override void Display() {
			Console.WriteLine("I am a Barbarian!");
		}
	}

	/// <summary>
	/// Refined Abstraction: Extends the abstraction with specific character type behavior
	/// </summary>
	public class Mage : Character {
		public Mage(ICharacterBehavior behavior) : base(behavior) { }

		public override void Display() {
			Console.WriteLine("I am a Mage.");
		}
	}
}
