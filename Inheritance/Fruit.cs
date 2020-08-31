using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
   public abstract class Fruit
    {
        public string Color { get; set; }
        public virtual void FruitColor()
        {
            Console.WriteLine("You have a multiple colors of Fruit");
        }
    }
}
