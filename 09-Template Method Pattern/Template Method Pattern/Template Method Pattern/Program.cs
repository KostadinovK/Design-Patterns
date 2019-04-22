using System;

namespace Template_Method_Pattern
{
    public class Program
    {
        public static void Main()
        {
            var tea = new Tea();
            var coffee = new Coffee();

            tea.MakeBeverage();
            coffee.MakeBeverage();
        }
    }
}
