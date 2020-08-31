using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Apple : Fruit
    {
        public Apple()
        {
            Color = "Red";
        }
        public override void FruitColor()
        {
            base.FruitColor();
            Console.WriteLine($"Apple has {Color} Color.");
        }
    }

}
