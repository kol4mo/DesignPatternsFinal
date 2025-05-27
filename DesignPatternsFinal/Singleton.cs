using System;

namespace DesignPatternsDemo {
	/// <summary>
	/// Generic Singleton Base Class: Ensures only one instance exists for any derived class
	/// </summary>
	/// <typeparam name="T">The type of class that should be a singleton</typeparam>
	public abstract class SingletonBase<T> where T : class {
		// Static Instance: Stores the single instance of the class
		private static T? instance;

		// Public Static Method: Provides global access to the instance
		public static T Instance {
			get {
				if (instance == null) {
					instance = SetInstance();
				}
				return instance;
			}
		}

		// Private method to create the instance using reflection
		private static T SetInstance() {
			return (T)Activator.CreateInstance(typeof(T), true)!;
		}

		// For testing purposes
		public static void Reset() {
			instance = null;
		}
	}
}
