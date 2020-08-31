using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Apple : Fruit
    {
        public string Type { get; set; }
        public Apple()
        {
            Colour = "Red";
            Type = "Red Delicious";
        }
        public override void FruitColor()
        {
            base.FruitColor();
            Console.WriteLine($"Apple has {Color} Color.");
        }
    }

}
