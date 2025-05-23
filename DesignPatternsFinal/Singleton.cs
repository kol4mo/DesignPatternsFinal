using System;

namespace DesignPatternsDemo {
	public abstract class SingletonBase<T> where T : class {
		private static T? instance;

		public static T Instance {
			get {
				if (instance == null) {
					instance = SetInstance();
				}
				return instance;
			}
		}

		private static T SetInstance() {
			return (T)Activator.CreateInstance(typeof(T), true)!;
		}

		// For testing purposes
		public static void Reset() {
			instance = null;
		}
	}
}
