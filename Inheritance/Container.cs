using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Inheritance
{
   public abstract class Container
    {
        // The Container will have a Capacity and Contents property and a Search() method.The search method will write "You open the container."  

        public int Capacity { get; set; }
        public int Contents { get; set; }

        public virtual void Search()
        {
            Console.WriteLine("You Open the container.");
        }

    }
}
