using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Orange : Fruit
    {
        public Orange()
        {
            Color = "Orange";
        }
        public override void FruitColor()
        {
            base.FruitColor();
            Console.WriteLine($"Orange has {Color} Color.");
        }
    }
}
