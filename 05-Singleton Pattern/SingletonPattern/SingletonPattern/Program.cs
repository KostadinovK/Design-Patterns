using System;

namespace SingletonPattern
{
    public class Program
    {
        public static void Main()
        {
            BellSingleton bell = BellSingleton.Instance;

            bell.Ring();
        }
    }
}
