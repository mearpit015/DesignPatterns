using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    /// <summary>
    /// Singletone pattern class implementation with thread safety.
    /// </summary>
    public sealed class SingletonPattern
    {
        // volatile keyword indicates property we are using that can be executing into different threads as well at the same time.
        public static volatile SingletonPattern instance;
        private static object lockObject = new object();
        private SingletonPattern()
        {
            // singletone classes are private. So that developers can avoid creating instance of class.
        }

        public static SingletonPattern Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonPattern();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
