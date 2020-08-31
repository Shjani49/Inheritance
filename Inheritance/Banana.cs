using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Banana : Fruit
    {
        public Banana()
        {
            Color = "Yellow";
        }
        public override void FruitColor()
        {
            base.FruitColor();
            Console.WriteLine($"Banana has {Color} Color.");
        }

    }
}
