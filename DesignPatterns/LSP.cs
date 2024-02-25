using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    /// <summary>
    /// liskov substitution principle. Instance of child class should replace the instance of Parent with out changing the result set.
    /// </summary>
    internal class LSP
    {
        public void PrintLSP()
        {
            Fruit fruit = new Apple();
            fruit.GetColor();
            // Print apple colors.
            fruit = new Orange();
            fruit.GetColor();
            // Print Orange color.
        }

    }

    internal abstract class Fruit
    {
        public abstract void GetColor();
    }

    internal class Apple : Fruit
    {
        public override void GetColor()
        {
            Console.WriteLine("Red, Green");
        }
    }

    internal class Orange : Fruit
    {
        public override void GetColor()
        {
            Console.WriteLine("Orangce");
        }
    }
}
