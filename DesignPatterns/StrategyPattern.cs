using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace DesignPatterns
{
    /// <summary>
    /// we used this pattern to change object on the fly in our application
    /// </summary>
    internal class StrategyPattern
    {
        IChoice choice;
        /*It's our choice. We prefer to use a setter method instead of
        using a constructor. We can call this method whenever we want to
        change the "choice behavior" on the fly*/
        public void SetChoice(IChoice choice)
        {
            this.choice = choice;
        }
        /* This method will help us to delegate the particular
        object's choice behavior/characteristic*/
        public void ShowChoice()
        {
            choice.MyChoice();
        }
    }

    public interface IChoice
    {
        void MyChoice();
    }

    public class FirstChoice : IChoice
    {        
        public void MyChoice()
        {
            Console.WriteLine("Traveling to Japan\n");
        }
    }

    public class SecondChoice : IChoice
    {
        public void MyChoice()
        {
            Console.WriteLine("Traveling to India\n");
        }
    }
}
