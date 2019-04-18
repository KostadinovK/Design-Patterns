using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public sealed class BellSingleton
    {
        private static BellSingleton instance;

        private static object syncRoot = new Object();

        /*The getter is thread safe*/
        public static BellSingleton Instance
        {
            get 
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new BellSingleton();
                    }

                    return instance;
                }
            }
        }

        private BellSingleton() { }

        public void Ring()
        {
            Console.WriteLine("Bell is Ringing...");
        }
    }
}
