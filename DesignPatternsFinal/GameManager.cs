using System;

namespace DesignPatternsDemo
{
    public class GameManager
    {
        private static GameManager? instance;
        private static readonly object lockObject = new object();
        
        
        // Private constructor to prevent direct instantiation
        private GameManager()
        {
        }
        
        public static GameManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        instance ??= new GameManager();
                    }
                }
                return instance;
            }
        }
        
        
        
        

        // Added for testing purposes
        public static void Reset()
        {
            instance = null;
        }
    }
} 