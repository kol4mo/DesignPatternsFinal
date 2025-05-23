using System;

namespace DesignPatternsDemo {
	public abstract class SingletonBase<T> where T : class {
		private static T? instance;
		private static readonly object lockObject = new object();

		public static T Instance {
			get {
				if (instance == null) {
					lock (lockObject) {
						instance ??= (T)Activator.CreateInstance(typeof(T), true)!;
					}
				}
				return instance;
			}
		}

		// For testing purposes
		public static void Reset() {
			instance = null;
		}
	}
}
