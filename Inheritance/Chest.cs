﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Chest : Container
    {
        
        public Chest()
        {
            Capacity = 8;
          
        }
        public override void Search()
        {
            base.Search();
            Console.WriteLine($"The Chest contains {Contents.Count} items of a maximum {Capacity}.");
        }
    }
}
