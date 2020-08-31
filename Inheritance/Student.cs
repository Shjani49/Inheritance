﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    // By adding a colon and another class, we inherit from that class.
    public abstract class Student : Person
    {
        public int StudentID { get; set; }

        // If we want to open this method up to be overridden, it must be marked as "virtual".
        public virtual void AttendClass()
        {
            Console.WriteLine("Attending class for me involves doing school work.");
        }
    }
}
