﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericDemo
{
   public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Id : {Id} - Name {Name}";
        }
    }
}
