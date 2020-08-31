using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Box : Container
    {
       
        public Box()
        {
            Capacity = 6;
            Contents = 2;
        }
        public override void Search()
        {
            base.Search();
            Console.WriteLine($"The Boxe contains {Contents} items of a maximum {Capacity}.");
        }
    }

}
